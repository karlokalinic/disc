using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct BeginSessionOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private AntiCheatClientMode m_Mode;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public AntiCheatClientMode Mode
		{
			set
			{
			}
		}

		public void Set(BeginSessionOptions other)
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
