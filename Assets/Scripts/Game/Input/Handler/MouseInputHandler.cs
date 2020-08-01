using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace CQ.LeagueOfLegends.Game
{
	public class MouseInputHandler : InputHandlerBase, Rift.IMouseActions
	{
		public Camera currentCamera; 
		// public NavMeshAgent agent;
		public LayerMask groundLayer;
		
		protected override void Awake()
		{
			base.Awake();
			
			rift.Mouse.SetCallbacks(this);
			
			currentCamera = Camera.main;
			// agent = GetComponent<NavMeshAgent>();
		}

		void OnEnable()
		{
			rift.Mouse.Enable();
		}

		void OnDisable()
		{
			rift.Mouse.Disable();
		}
		
		public void OnLeft(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnLeft");
		}

		public void OnRight(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnRight");

			if (context.started)
			{
				if (GetMouseUnderObject(out var hit))
				{
					var localPlayer = UnitManager.Instance.GetLoaclPlayer();
					
					if (hit.collider.CompareTag("Enemy"))
					{
						localPlayer.Attack(hit.collider.gameObject.GetComponent<AttackableUnit>());
					} 
					else if (hit.collider.CompareTag("Floor"))
					{
						localPlayer.Move(hit.point);
					}
					else if (hit.collider.CompareTag("Neutral"))
					{
						localPlayer.Attack(hit.collider.gameObject.GetComponent<AttackableUnit>());
					}
					else if (hit.collider.CompareTag("Team"))
					{
						localPlayer.Move(hit.point);
					}
					else
					{
						Debug.Log($"Hit! :: {hit.transform.gameObject}", hit.transform.gameObject);	
					}
				}
			}
		}

		void MoveTo(Vector3 pos)
		{
			// agent.SetDestination(pos);
		}

		public bool GetMouseUnderObject(out RaycastHit hifInfo)
		{
			// 레이를 만들고,
			Ray ray = currentCamera.ScreenPointToRay(Mouse.current.position.ReadValue());

			// 쏩니다.
			if (Physics.Raycast(ray, out hifInfo, float.MaxValue, groundLayer))
			{
				// Debug.Log($"Hit! :: {hifInfo.point}");
				return true;
			}

			return false;
		}
	}
}