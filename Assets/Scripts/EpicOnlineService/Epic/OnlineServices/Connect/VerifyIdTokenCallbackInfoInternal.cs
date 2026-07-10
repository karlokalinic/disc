using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 88)]
	internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

		private IntPtr m_ProductUserId;

		private int m_IsAccountInfoPresent;

		private ExternalAccountType m_AccountIdType;

		private IntPtr m_AccountId;

		private IntPtr m_Platform;

		private IntPtr m_DeviceType;

		private IntPtr m_ClientId;

		private IntPtr m_ProductId;

		private IntPtr m_SandboxId;

		private IntPtr m_DeploymentId;

		public Result ResultCode => default(Result);

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public ProductUserId ProductUserId => null;

		public bool IsAccountInfoPresent => false;

		public ExternalAccountType AccountIdType => default(ExternalAccountType);

		public string AccountId => null;

		public string Platform => null;

		public string DeviceType => null;

		public string ClientId => null;

		public string ProductId => null;

		public string SandboxId => null;

		public string DeploymentId => null;
	}
}
