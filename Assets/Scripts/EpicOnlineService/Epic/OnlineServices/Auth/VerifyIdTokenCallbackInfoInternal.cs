using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 96)]
	internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

		private IntPtr m_ApplicationId;

		private IntPtr m_ClientId;

		private IntPtr m_ProductId;

		private IntPtr m_SandboxId;

		private IntPtr m_DeploymentId;

		private IntPtr m_DisplayName;

		private int m_IsExternalAccountInfoPresent;

		private ExternalAccountType m_ExternalAccountIdType;

		private IntPtr m_ExternalAccountId;

		private IntPtr m_ExternalAccountDisplayName;

		private IntPtr m_Platform;

		public Result ResultCode => default(Result);

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public string ApplicationId => null;

		public string ClientId => null;

		public string ProductId => null;

		public string SandboxId => null;

		public string DeploymentId => null;

		public string DisplayName => null;

		public bool IsExternalAccountInfoPresent => false;

		public ExternalAccountType ExternalAccountIdType => default(ExternalAccountType);

		public string ExternalAccountId => null;

		public string ExternalAccountDisplayName => null;

		public string Platform => null;
	}
}
