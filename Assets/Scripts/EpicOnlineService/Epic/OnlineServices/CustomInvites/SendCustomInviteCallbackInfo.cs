namespace Epic.OnlineServices.CustomInvites
{
	public class SendCustomInviteCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public ProductUserId[] TargetUserIds { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(SendCustomInviteCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
