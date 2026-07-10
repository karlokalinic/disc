using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatServer
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct UnregisterClientOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_ClientHandle;

		public IntPtr ClientHandle
		{
			set
			{
			}
		}

		public void Set(UnregisterClientOptions other)
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
