using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct OnClientActionRequiredCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		private IntPtr m_ClientHandle;

		private AntiCheatCommonClientAction m_ClientAction;

		private AntiCheatCommonClientActionReason m_ActionReasonCode;

		private IntPtr m_ActionReasonDetailsString;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public IntPtr ClientHandle => (IntPtr)0;

		public AntiCheatCommonClientAction ClientAction => default(AntiCheatCommonClientAction);

		public AntiCheatCommonClientActionReason ActionReasonCode => default(AntiCheatCommonClientActionReason);

		public string ActionReasonDetailsString => null;
	}
}
