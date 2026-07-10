using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct OnClientAuthStatusChangedCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_ClientHandle;

		private AntiCheatCommonClientAuthStatus m_ClientAuthStatus;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public IntPtr ClientHandle => (IntPtr)0;

		public AntiCheatCommonClientAuthStatus ClientAuthStatus => default(AntiCheatCommonClientAuthStatus);
	}
}
