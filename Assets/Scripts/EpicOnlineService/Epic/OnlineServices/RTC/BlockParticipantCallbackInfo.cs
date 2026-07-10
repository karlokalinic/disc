namespace Epic.OnlineServices.RTC
{
	public class BlockParticipantCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public string RoomName { get; private set; }

		public ProductUserId ParticipantId { get; private set; }

		public bool Blocked { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(BlockParticipantCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
