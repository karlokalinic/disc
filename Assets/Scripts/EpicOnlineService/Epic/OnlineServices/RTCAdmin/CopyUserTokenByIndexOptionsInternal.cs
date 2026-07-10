using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 12)]
	internal struct CopyUserTokenByIndexOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_UserTokenIndex;

		private uint m_QueryId;

		public uint UserTokenIndex
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

		public void Set(CopyUserTokenByIndexOptions other)
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
