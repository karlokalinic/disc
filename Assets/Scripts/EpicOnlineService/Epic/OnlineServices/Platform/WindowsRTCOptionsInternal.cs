using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct WindowsRTCOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_PlatformSpecificOptions;

		public WindowsRTCOptionsPlatformSpecificOptions PlatformSpecificOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(WindowsRTCOptions other)
		{
		}

		public void Set(object other)
		{
		}

		public void Dispose()
		{
		}
	}
}
