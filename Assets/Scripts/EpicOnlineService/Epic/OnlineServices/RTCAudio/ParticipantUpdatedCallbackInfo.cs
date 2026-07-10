namespace Epic.OnlineServices.RTCAudio
{
	public class ParticipantUpdatedCallbackInfo : ICallbackInfo, ISettable
	{
		public object ClientData { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public string RoomName { get; private set; }

		public ProductUserId ParticipantId { get; private set; }

		public bool Speaking { get; private set; }

		public RTCAudioStatus AudioStatus { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ParticipantUpdatedCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
