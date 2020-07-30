using System;
using System.Runtime.InteropServices;
using UnityEngine;

#if UNITY_STANDALONE_WIN
namespace CQ.Native
{
	public class Win32
	{
		[Flags]
		public enum MouseEventFlags
		{
			LeftDown = 0x00000002,
			LeftUp = 0x00000004,
			MiddleDown = 0x00000020,
			MiddleUp = 0x00000040,
			Move = 0x00000001,
			Absolute = 0x00008000,
			RightDown = 0x00000008,
			RightUp = 0x00000010
		}
		
		[DllImport("User32.Dll")]
		public static extern long SetCursorPos(int x, int y);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCursorPos(out POINT lpPoint);

		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
		
		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{
			public int X;
			public int Y;

			public POINT(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}
		}

		public static void SetCursorPos(float x, float y)
		{
			SetCursorPos((int) x, (int) y);
		}

		public static Vector2 GetCursorPos()
		{
			GetCursorPos(out var p);
			return new Vector2(p.X, p.Y);
		}
		
		public static POINT GetCursorPosition()
		{
			POINT currentMousePoint;
			var gotPoint = GetCursorPos(out currentMousePoint);
			if (!gotPoint) { currentMousePoint = new POINT(0, 0); }
			return currentMousePoint;
		}
		
		public static void MouseEvent(MouseEventFlags value)
		{
			POINT position = GetCursorPosition();

			mouse_event
				((int)value,
					position.X,
					position.Y,
					0,
					0)
				;
		}
	}
}
#endif