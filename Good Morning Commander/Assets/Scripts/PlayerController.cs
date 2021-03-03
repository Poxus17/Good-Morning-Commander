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

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
        isMoving = false;
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
            }
        }

        


        
    }
}
