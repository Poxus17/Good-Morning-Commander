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
<<<<<<< HEAD
    GameObject indicatorRef;

=======
    public RoutineMngr routineMngr;
    public BasicInkExample inkComm;
>>>>>>> parent of c8edddb (Revert "TMP Fixes")
    void Start()
    {
        routineMngr.routine.State = "Work";
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
<<<<<<< HEAD
=======
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleActive_Brain();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log(routineMngr.routine.State);
        }
>>>>>>> parent of c8edddb (Revert "TMP Fixes")

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

                if (hit.transform.tag == "Couch" && routineMngr.routine.State == "Psych") //Activate psychology session
                {
                    Debug.Log("[Couch] (Ink on/off code)");
<<<<<<< HEAD
                    MakeActive_Dialogue();
=======
                    ToggleActive_Dialogue();
                    inkComm.StartStory();
                    if (brainVisible == true)
                    {
                        ToggleActive_Brain();
                    }
>>>>>>> parent of c8edddb (Revert "TMP Fixes")
                }
                //if (hit.transform.tag == "Couch" && routineMngr.routine.State == "Work") //wrong routine 
                //{
                //    Debug.Log("YOU SHOULD GO TO WORK BEFORE VISITING THE PSYCH");
                //}

                if (hit.transform.tag == "Computer" && routineMngr.routine.State == "Work") //Activate Work Terminal
                {
                    Debug.Log("[Computer] (Ink on/off code)");
<<<<<<< HEAD
                    MakeActive_Computer();
                    MakeActive_Brain();
                }

                if(hit.transform.tag == "Dimmer")
                {
=======
                    ToggleActive_Computer();
                    if(brainVisible == true)
                    {
                        ToggleActive_Brain();
                    }
                }

                //if (hit.transform.tag == "Computer" && routineMngr.routine.State == "Psych") //wrong routine
                //{
                //    Debug.Log("WORKDAY IS OVER, YOU SHOULD VISIT THE PSYCH");
                //}

                if (hit.transform.tag == "Bed" && routineMngr.routine.State == "Sleep") //Activate Work Terminal
                {
                    routineMngr.routine.State = "Work";
                }

                if (hit.transform.tag == "Dimmer")
                {                                                
>>>>>>> parent of c8edddb (Revert "TMP Fixes")
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
