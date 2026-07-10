using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct KickOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_RoomName;

		private IntPtr m_TargetUserId;

		public string RoomName
		{
			set
			{
			}
		}

		public ProductUserId TargetUserId
		{
			set
			{
			}
		}

		public void Set(KickOptions other)
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
