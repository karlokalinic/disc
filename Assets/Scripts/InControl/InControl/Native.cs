using System;
using System.Runtime.InteropServices;

namespace InControl
{
	internal static class Native
	{
		private const string libraryName = "InControlNative";

		private const CallingConvention callingConvention = CallingConvention.Cdecl;

		[PreserveSig]
		public static extern void Init(NativeInputOptions options);

		[PreserveSig]
		public static extern void Stop();

		[PreserveSig]
		public static extern void GetVersionInfo(out NativeVersionInfo versionInfo);

		[PreserveSig]
		public static extern bool GetDeviceInfo(uint handle, out InputDeviceInfo deviceInfo);

		[PreserveSig]
		public static extern bool GetDeviceState(uint handle, out IntPtr deviceState);

		[PreserveSig]
		public static extern int GetDeviceEvents(out IntPtr deviceEvents);

		[PreserveSig]
		public static extern void SetHapticState(uint handle, byte motor0, byte motor1);

		[PreserveSig]
		public static extern void SetLightColor(uint handle, byte red, byte green, byte blue);

		[PreserveSig]
		public static extern void SetLightFlash(uint handle, byte flashOnDuration, byte flashOffDuration);
	}
}
