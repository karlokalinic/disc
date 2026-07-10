using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct RegisterPlatformAudioUserOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_UserId;

		public string UserId
		{
			set
			{
			}
		}

		public void Set(RegisterPlatformAudioUserOptions other)
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
