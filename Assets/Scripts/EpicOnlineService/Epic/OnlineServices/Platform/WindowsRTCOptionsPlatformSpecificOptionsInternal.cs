using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct WindowsRTCOptionsPlatformSpecificOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_XAudio29DllPath;

		public string XAudio29DllPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(WindowsRTCOptionsPlatformSpecificOptions other)
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
