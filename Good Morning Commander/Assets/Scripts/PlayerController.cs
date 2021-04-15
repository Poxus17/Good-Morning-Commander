using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Camera cam;
    bool isMoving = false;

    public delegate void MoveStatusChange(bool status);
    public static event MoveStatusChange OnMoveStatusChanged;

    public GameObject dialogueCanvas;
    bool dialogueVisible = false;

    public GameObject computerCanvas;
    bool computerVisible = false;

    public GameObject brainCanvas;
    bool brainVisible = false;

    bool activeDimmer;

    public delegate void Dim(float factor);
    public static event Dim OnDim;

    public GameObject indicatorPrefab;
    GameObject indicatorRef;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
        dialogueCanvas.SetActive(false);
        computerCanvas.SetActive(false);
        //brainCanvas.SetActive(false);

        activeDimmer = false;
    }
    void Update()
    {

        if (isMoving)
        {
            if (navMeshAgent.remainingDistance == 0)
            {
                isMoving = false;
                if (OnMoveStatusChanged != null)
                {
                    OnMoveStatusChanged(false);
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                #region Disable all active dialog
                if (dialogueVisible == true)
                {
                    { dialogueCanvas.SetActive(false); dialogueVisible = false; }
                }
                if (computerVisible == true)
                {
                    { computerCanvas.SetActive(false); computerVisible = false; }
                }
                if (brainVisible == true)
                {
                    { brainCanvas.SetActive(false); brainVisible = false; }
                }
                #endregion

                navMeshAgent.SetDestination(hit.point);
                isMoving = true;
                
                if (OnMoveStatusChanged != null)
                {
                    OnMoveStatusChanged(true);
                }

                if(indicatorRef == null)
                {
                    indicatorRef = Instantiate(indicatorPrefab, hit.point, Quaternion.identity);
                }
                else
                {
                    indicatorRef.transform.position = hit.point;
                }

                if (hit.transform.tag == "Couch") //Activate psychology session
                {
                    Debug.Log("[Couch] (Ink on/off code)");
                    MakeActive_Dialogue();
                }

                if (hit.transform.tag == "Computer") //Activate Work Terminal
                {
                    Debug.Log("[Computer] (Ink on/off code)");
                    MakeActive_Computer();
                    MakeActive_Brain();
                }

                if(hit.transform.tag == "Dimmer")
                {
                    activeDimmer = true;
                }

            }

            
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeDimmer = false;
        }

        if (activeDimmer)
        {
            if(OnDim != null) //If this event has subscribers
            {
                OnDim(Input.GetAxis("Mouse Y"));
            }
        }

        void MakeActive_Dialogue()
        {
            if (dialogueVisible == false)
            { dialogueCanvas.SetActive(true); dialogueVisible = true; return;} 
            if (dialogueVisible == true)
            { dialogueCanvas.SetActive(false); dialogueVisible = false; } 
        }

        void MakeActive_Computer()
        {
            if (computerVisible == false)
            { computerCanvas.SetActive(true); computerVisible = true; return; }
            if (computerVisible == true)
            { computerCanvas.SetActive(false); computerVisible = false; }
        }
        void MakeActive_Brain()
        {
            if (brainVisible == false)
            { brainCanvas.SetActive(true); brainVisible = true; return; }
            if (brainVisible == true)
            { brainCanvas.SetActive(false); brainVisible = false; }
        }
        //bool allowCouch = false;

        //void OnCollisionEnter(Collision collision)
        //{
        //    if (collision.gameObject.tag == "Couch_Distance")
        //    {
        //        allowCouch = true;
        //        Debug.Log("Allow Couch");
        //    }
        //    else { allowCouch = false; }

        //}


    }
}
