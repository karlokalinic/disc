namespace Epic.OnlineServices.RTCAudio
{
	public class UpdateReceivingCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public string RoomName { get; private set; }

		public ProductUserId ParticipantId { get; private set; }

		public bool AudioEnabled { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(UpdateReceivingCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
