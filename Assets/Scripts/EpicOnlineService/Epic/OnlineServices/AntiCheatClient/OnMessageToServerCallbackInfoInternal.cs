using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct OnMessageToServerCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_MessageData;

		private uint m_MessageDataSizeBytes;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public byte[] MessageData => null;
	}
}
