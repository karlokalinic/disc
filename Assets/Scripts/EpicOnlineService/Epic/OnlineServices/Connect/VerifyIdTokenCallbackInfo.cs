namespace Epic.OnlineServices.Connect
{
	public class VerifyIdTokenCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public ProductUserId ProductUserId { get; private set; }

		public bool IsAccountInfoPresent { get; private set; }

		public ExternalAccountType AccountIdType { get; private set; }

		public string AccountId { get; private set; }

		public string Platform { get; private set; }

		public string DeviceType { get; private set; }

		public string ClientId { get; private set; }

		public string ProductId { get; private set; }

		public string SandboxId { get; private set; }

		public string DeploymentId { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(VerifyIdTokenCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
