using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct ParticipantUpdatedCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_LocalUserId;

		private IntPtr m_RoomName;

		private IntPtr m_ParticipantId;

		private int m_Speaking;

		private RTCAudioStatus m_AudioStatus;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public ProductUserId LocalUserId => null;

		public string RoomName => null;

		public ProductUserId ParticipantId => null;

		public bool Speaking => false;

		public RTCAudioStatus AudioStatus => default(RTCAudioStatus);
	}
}
