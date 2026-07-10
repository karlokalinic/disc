using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct QueryJoinRoomTokenCompleteCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

		private IntPtr m_RoomName;

		private IntPtr m_ClientBaseUrl;

		private uint m_QueryId;

		private uint m_TokenCount;

		public Result ResultCode => default(Result);

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public string RoomName => null;

		public string ClientBaseUrl => null;

		public uint QueryId => 0u;

		public uint TokenCount => 0u;
	}
}
