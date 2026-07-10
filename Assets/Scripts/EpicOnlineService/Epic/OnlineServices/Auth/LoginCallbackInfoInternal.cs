using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 56)]
	internal struct LoginCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

		private IntPtr m_LocalUserId;

		private IntPtr m_PinGrantInfo;

		private IntPtr m_ContinuanceToken;

		private IntPtr m_AccountFeatureRestrictedInfo;

		private IntPtr m_SelectedAccountId;

		public Result ResultCode => default(Result);

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public EpicAccountId LocalUserId => null;

		public PinGrantInfo PinGrantInfo => null;

		public ContinuanceToken ContinuanceToken => null;

		public AccountFeatureRestrictedInfo AccountFeatureRestrictedInfo => null;

		public EpicAccountId SelectedAccountId => null;
	}
}
