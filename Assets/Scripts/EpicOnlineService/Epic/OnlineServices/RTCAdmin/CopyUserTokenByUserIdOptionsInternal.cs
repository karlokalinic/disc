using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct CopyUserTokenByUserIdOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_TargetUserId;

		private uint m_QueryId;

		public ProductUserId TargetUserId
		{
			set
			{
			}
		}

		public uint QueryId
		{
			set
			{
			}
		}

		public void Set(CopyUserTokenByUserIdOptions other)
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
