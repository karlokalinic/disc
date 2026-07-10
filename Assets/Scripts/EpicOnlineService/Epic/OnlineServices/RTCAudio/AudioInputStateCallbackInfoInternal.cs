using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct AudioInputStateCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_LocalUserId;

		private IntPtr m_RoomName;

		private RTCAudioInputStatus m_Status;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public ProductUserId LocalUserId => null;

		public string RoomName => null;

		public RTCAudioInputStatus Status => default(RTCAudioInputStatus);
	}
}
