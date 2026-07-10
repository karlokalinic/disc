using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 48)]
	internal struct UpdateReceivingCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

		private IntPtr m_LocalUserId;

		private IntPtr m_RoomName;

		private IntPtr m_ParticipantId;

		private int m_AudioEnabled;

		public Result ResultCode => default(Result);

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public ProductUserId LocalUserId => null;

		public string RoomName => null;

		public ProductUserId ParticipantId => null;

		public bool AudioEnabled => false;
	}
}
