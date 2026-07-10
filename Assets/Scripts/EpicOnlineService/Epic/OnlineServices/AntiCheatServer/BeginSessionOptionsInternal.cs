using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatServer
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct BeginSessionOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_RegisterTimeoutSeconds;

		private IntPtr m_ServerName;

		private int m_EnableGameplayData;

		private IntPtr m_LocalUserId;

		public uint RegisterTimeoutSeconds
		{
			set
			{
			}
		}

		public string ServerName
		{
			set
			{
			}
		}

		public bool EnableGameplayData
		{
			set
			{
			}
		}

		public ProductUserId LocalUserId
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
