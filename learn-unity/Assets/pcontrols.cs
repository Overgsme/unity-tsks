using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pcontrols : MonoBehaviour
{
    private Camera mCamera;
    private NavMeshAgent agent;

    private void Start()
    {
        mCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();

    }
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(mCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.SetDestination(hit.point);
            }
            
        }
    }
}
