using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct IdTokenInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_AccountId;

		private IntPtr m_JsonWebToken;

		public EpicAccountId AccountId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string JsonWebToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(IdToken other)
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
