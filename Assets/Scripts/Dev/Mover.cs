using System.Collections;
using System.Collections.Generic;
using CQ.LeagueOfLegends;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    public Camera currentCamera; 
    public NavMeshAgent agent;
    public LayerMask groundLayer;
    
    // Start is called before the first frame update
    void Start()
    {
        currentCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // 레이를 만들고,
            Ray ray = currentCamera.ScreenPointToRay(Input.mousePosition);
				
            // 쏩니다.
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, groundLayer))
            {
                // 이 안으로 들어왔다면 맞았다는 뜻이며, MoveTo 시킵니다.
                MoveTo(hit.point);
            }
        }
    }
    
    void MoveTo(Vector3 pos)
    {
        agent.SetDestination(pos);
    }
}
