using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct OnMessageToClientCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_ClientHandle;

		private IntPtr m_MessageData;

		private uint m_MessageDataSizeBytes;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public IntPtr ClientHandle => (IntPtr)0;

		public byte[] MessageData => null;
	}
}
