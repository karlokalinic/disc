using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.CustomInvites
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct OnCustomInviteReceivedCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_TargetUserId;

		private IntPtr m_LocalUserId;

		private IntPtr m_CustomInviteId;

		private IntPtr m_Payload;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public ProductUserId TargetUserId => null;

		public ProductUserId LocalUserId => null;

		public string CustomInviteId => null;

		public string Payload => null;
	}
}
