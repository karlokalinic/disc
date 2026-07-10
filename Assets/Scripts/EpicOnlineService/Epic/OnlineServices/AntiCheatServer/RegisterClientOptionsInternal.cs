using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;

namespace Epic.OnlineServices.AntiCheatServer
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct RegisterClientOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_ClientHandle;

		private AntiCheatCommonClientType m_ClientType;

		private AntiCheatCommonClientPlatform m_ClientPlatform;

		private IntPtr m_AccountId;

		private IntPtr m_IpAddress;

		public IntPtr ClientHandle
		{
			set
			{
			}
		}

		public AntiCheatCommonClientType ClientType
		{
			set
			{
			}
		}

		public AntiCheatCommonClientPlatform ClientPlatform
		{
			set
			{
			}
		}

		public string AccountId
		{
			set
			{
			}
		}

		public string IpAddress
		{
			set
			{
			}
		}

		public void Set(RegisterClientOptions other)
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
