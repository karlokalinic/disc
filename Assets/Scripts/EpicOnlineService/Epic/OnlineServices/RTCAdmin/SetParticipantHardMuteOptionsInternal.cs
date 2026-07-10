using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct SetParticipantHardMuteOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_RoomName;

		private IntPtr m_TargetUserId;

		private int m_Mute;

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

		public bool Mute
		{
			set
			{
			}
		}

		public void Set(SetParticipantHardMuteOptions other)
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
