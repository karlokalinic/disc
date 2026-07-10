using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct UserTokenInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_ProductUserId;

		private IntPtr m_Token;

		public ProductUserId ProductUserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Token
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(UserToken other)
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
