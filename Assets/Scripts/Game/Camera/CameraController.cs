using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CQ.Native;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CQ.LeagueOfLegends.Game
{
	public class CameraController : MonoBehaviour, Rift.ICameraActions
	{
		public Vector3 minXY;
		public Vector3 maxXY;
		
		class CameraState
		{
			public float yaw;
			public float pitch;
			public float roll;
			public float x;
			public float y;
			public float z;

			CameraController controller;

			public void SetFromTransform(Transform t)
			{
				pitch = t.eulerAngles.x;
				yaw = t.eulerAngles.y;
				roll = t.eulerAngles.z;
				x = t.position.x;
				y = t.position.y;
				z = t.position.z;
			}

			public void SetUp(CameraController controller)
			{
				this.controller = controller;
			}

			public void Translate(Vector3 translation)
			{
				Vector3 rotatedTranslation = Quaternion.Euler(pitch, yaw, roll) * translation;

				x += rotatedTranslation.x;
				y += rotatedTranslation.y;
				z += rotatedTranslation.z;

				x = Mathf.Min(x, controller.maxXY.x);
				z = Mathf.Min(z, controller.maxXY.z);
				
				x = Mathf.Max(x, controller.minXY.x);
				z = Mathf.Max(z, controller.minXY.z);
			}

			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
				yaw = Mathf.Lerp(yaw, target.yaw, rotationLerpPct);
				pitch = Mathf.Lerp(pitch, target.pitch, rotationLerpPct);
				roll = Mathf.Lerp(roll, target.roll, rotationLerpPct);

				x = Mathf.Lerp(x, target.x, positionLerpPct);
				y = Mathf.Lerp(y, target.y, positionLerpPct);
				z = Mathf.Lerp(z, target.z, positionLerpPct);
			}

			public void UpdateTransform(Transform t)
			{
				t.eulerAngles = new Vector3(pitch, yaw, roll);
				t.position = new Vector3(x, y, z);
			}
		}

		CameraState m_TargetCameraState = new CameraState();
		CameraState m_InterpolatingCameraState = new CameraState();

		[Header("Movement Settings")] [Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost = 3.5f;

		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target."), Range(0.001f, 1f)]
		public float positionLerpTime = 0.2f;

		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve =
			new AnimationCurve(new Keyframe(0f, 0.5f, 0f, 5f), new Keyframe(1f, 2.5f, 0f, 0f));

		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target."), Range(0.001f, 1f)]
		public float rotationLerpTime = 0.01f;

		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		public Vector2 threshold = new Vector2(5, 5);
		public float multiplier = 3;

		bool isFocusingLocalplayer = false;

		void OnEnable()
		{
			m_TargetCameraState.SetFromTransform(transform);
			m_TargetCameraState.SetUp(this);
			m_InterpolatingCameraState.SetFromTransform(transform);
			m_InterpolatingCameraState.SetUp(this);
			
			Cursor.lockState = CursorLockMode.Confined;
			
			Win32.SetCursorPos(Screen.width * 0.5f, Screen.height * 0.5f);
			Win32.MouseEvent(Win32.MouseEventFlags.LeftDown);
			Win32.MouseEvent(Win32.MouseEventFlags.LeftUp);
			
			var rift = new Rift();
			rift.Camera.SetCallbacks(this);
			rift.Camera.Enable();
		}

		void Update()
		{
			if (!isFocusingLocalplayer)
			{
				Vector3 direction = GetMouseInput();

				if (pressed.Keys.Any(e => pressed[e]))
				{
					direction = GetKeyboardInput();
				}

				Vector3 translation = direction * Time.deltaTime * multiplier;
				translation *= Mathf.Pow(2.0f, boost);

				m_TargetCameraState.Translate(translation);

				// Framerate-independent interpolation
				// Calculate the lerp amount, such that we get 99% of the way to our target in the specified time
				var positionLerpPct = 1f - Mathf.Exp((Mathf.Log(1f - 0.99f) / positionLerpTime) * Time.deltaTime);
				var rotationLerpPct = 1f - Mathf.Exp((Mathf.Log(1f - 0.99f) / rotationLerpTime) * Time.deltaTime);
				m_InterpolatingCameraState.LerpTowards(m_TargetCameraState, positionLerpPct, rotationLerpPct);

				m_InterpolatingCameraState.UpdateTransform(transform);
			}
			else
			{
				// look at localplayer
				AIHeroClient localPlayer = UnitManager.Instance.GetLoaclPlayer();
			}
		}

		Vector3 GetMouseInput()
		{
			var mouse = Mouse.current.position.ReadValue();

			Vector3 direction = new Vector3();
			if (mouse.x < threshold.x)
			{
				// Move Left
				direction += Vector3.left;
			}
			else if (mouse.x > Screen.width - threshold.x)
			{
				// Move Right
				direction += Vector3.right;
			}

			if (mouse.y < threshold.y)
			{
				// Move Down
				direction += Vector3.back;
			}
			else if (mouse.y > Screen.height - threshold.y)
			{
				// Move Up
				direction += Vector3.forward;
			}

			return direction;
		}

		Vector3 GetKeyboardInput()
		{
			Vector3 direction = new Vector3();
			if (Keyboard.current.leftArrowKey.isPressed)
			{
				// Move Left
				direction += Vector3.left;
			}
			else if (Keyboard.current.rightArrowKey.isPressed)
			{
				// Move Right
				direction += Vector3.right;
			}

			if (Keyboard.current.downArrowKey.isPressed)
			{
				// Move Down
				direction += Vector3.back;
			}
			else if (Keyboard.current.upArrowKey.isPressed)
			{
				// Move Up
				direction += Vector3.forward;
			}

			return direction;
		}

		public void OnSetFocus(InputAction.CallbackContext context)
		{
			if (context.started)
			{
				isFocusingLocalplayer = true;
			}

			if (context.canceled)
			{
				isFocusingLocalplayer = false;
			}
		}

		public void OnToggleFocusLock(InputAction.CallbackContext context)
		{
			
		}

		Dictionary<string, bool> pressed = new Dictionary<string, bool>();

		public void OnLeft(InputAction.CallbackContext context)
		{
			if (context.started)
			{
				pressed[context.action.name] = true;
			}

			if (context.canceled)
			{
				pressed[context.action.name] = false;
			}
		}

		public void OnRight(InputAction.CallbackContext context)
		{
			if (context.started)
			{
				pressed[context.action.name] = true;
			}

			if (context.canceled)
			{
				pressed[context.action.name] = false;
			}
		}

		public void OnUp(InputAction.CallbackContext context)
		{
			if (context.started)
			{
				pressed[context.action.name] = true;
			}

			if (context.canceled)
			{
				pressed[context.action.name] = false;
			}
		}

		public void OnDown(InputAction.CallbackContext context)
		{
			if (context.started)
			{
				pressed[context.action.name] = true;
			}

			if (context.canceled)
			{
				pressed[context.action.name] = false;
			}
		}
	}
}