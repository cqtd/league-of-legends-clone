using CQ.LeagueOfLegends.Game;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Mover : InputHandlerBase, Rift.IMouseActions
{
    public Camera currentCamera; 
    public NavMeshAgent agent;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        currentCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();

        rift.Mouse.SetCallbacks(this);
        rift.Mouse.Enable();
    }
    
    void MoveTo(Vector3 pos)
    {
        agent.SetDestination(pos);
    }

    public void OnLeft(InputAction.CallbackContext context)
    {
        
    }

    public void OnRight(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Mouse Right");
            
            // 레이를 만들고,
            Ray ray = currentCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            
            // 쏩니다.
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, groundLayer))
            {
                // 이 안으로 들어왔다면 맞았다는 뜻이며, MoveTo 시킵니다.
                MoveTo(hit.point);
            }
        }

        if (context.canceled)
        {
            
        }
    }
}