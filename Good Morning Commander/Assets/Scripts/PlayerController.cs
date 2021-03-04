using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Camera cam;
    bool isMoving;
    
    public delegate void MoveStatusChange(bool status);
    public static event MoveStatusChange OnMoveStatusChanged;

    //bool allowCouch = false;
    public GameObject canvasObject;
    bool isCanvas = false;
        
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
        isMoving = false;
        canvasObject.SetActive(false);
    }

    // Update is called once per frame
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
                navMeshAgent.SetDestination(hit.point);
                isMoving = true;

                if (OnMoveStatusChanged != null)
                {
                    OnMoveStatusChanged(true);
                }

                if (hit.transform.tag == "Couch")
                {
                    //Ink on/off code goes here?
                    Debug.Log("[Couch] (Ink on/off code)");
                    MakeActive();
                }
            }
        }

        void MakeActive()
        {
            if (isCanvas == false)
            { canvasObject.SetActive(true); isCanvas = true; return;} 
            if (isCanvas == true)
            { canvasObject.SetActive(false); isCanvas = false; } 
        }

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
