using System;
using System.Runtime.InteropServices;

namespace XInputDotNetPure
{
	internal class Imports
	{
		[PreserveSig]
		public static extern uint XInputGamePadGetState32(uint playerIndex, IntPtr state);

		[PreserveSig]
		public static extern void XInputGamePadSetState32(uint playerIndex, float leftMotor, float rightMotor);

		[PreserveSig]
		public static extern uint XInputGamePadGetState64(uint playerIndex, IntPtr state);

		[PreserveSig]
		public static extern void XInputGamePadSetState64(uint playerIndex, float leftMotor, float rightMotor);

		public static uint XInputGamePadGetState(uint playerIndex, IntPtr state)
		{
			return 0u;
		}

		public static void XInputGamePadSetState(uint playerIndex, float leftMotor, float rightMotor)
		{
		}
	}
}
