namespace Epic.OnlineServices.CustomInvites
{
	public class OnCustomInviteReceivedCallbackInfo : ICallbackInfo, ISettable
	{
		public object ClientData { get; private set; }

		public ProductUserId TargetUserId { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public string CustomInviteId { get; private set; }

		public string Payload { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnCustomInviteReceivedCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
