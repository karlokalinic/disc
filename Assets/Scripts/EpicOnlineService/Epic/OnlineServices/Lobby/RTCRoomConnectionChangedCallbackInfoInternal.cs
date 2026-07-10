using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct RTCRoomConnectionChangedCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_LobbyId;

		private IntPtr m_LocalUserId;

		private int m_IsConnected;

		private Result m_DisconnectReason;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public string LobbyId => null;

		public ProductUserId LocalUserId => null;

		public bool IsConnected => false;

		public Result DisconnectReason => default(Result);
	}
}
