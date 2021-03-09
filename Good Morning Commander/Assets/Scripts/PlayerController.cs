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

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
        dialogueCanvas.SetActive(false);
        computerCanvas.SetActive(false);
        brainCanvas.SetActive(false);
    }
    void Update()
    {

        if (isMoving)
        {
            if (navMeshAgent.remainingDistance == 0)
            {
                if (OnMoveStatusChanged != null)
                {
                    OnMoveStatusChanged(false);
                    isMoving = false;
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
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

                navMeshAgent.SetDestination(hit.point);
                isMoving = true;
                
                if (OnMoveStatusChanged != null)
                {
                    OnMoveStatusChanged(true);
                }

                if (hit.transform.tag == "Couch")
                {
                    Debug.Log("[Couch] (Ink on/off code)");
                    MakeActive_Dialogue();
                }

                if (hit.transform.tag == "Computer")
                {
                    Debug.Log("[Computer] (Ink on/off code)");
                    MakeActive_Computer();
                    MakeActive_Brain();
                }
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
