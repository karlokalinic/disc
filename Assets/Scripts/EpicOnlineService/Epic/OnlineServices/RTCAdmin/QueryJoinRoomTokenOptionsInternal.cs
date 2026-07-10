using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 48)]
	internal struct QueryJoinRoomTokenOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private IntPtr m_RoomName;

		private IntPtr m_TargetUserIds;

		private uint m_TargetUserIdsCount;

		private IntPtr m_TargetUserIpAddresses;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public string RoomName
		{
			set
			{
			}
		}

		public ProductUserId[] TargetUserIds
		{
			set
			{
			}
		}

		public string TargetUserIpAddresses
		{
			set
			{
			}
		}

		public void Set(QueryJoinRoomTokenOptions other)
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
