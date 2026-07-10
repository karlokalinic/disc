using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct RTCOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_PlatformSpecificOptions;

		public IntPtr PlatformSpecificOptions
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		public void Set(RTCOptions other)
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
