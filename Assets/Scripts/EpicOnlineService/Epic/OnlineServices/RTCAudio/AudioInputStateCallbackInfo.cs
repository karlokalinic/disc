namespace Epic.OnlineServices.RTCAudio
{
	public class AudioInputStateCallbackInfo : ICallbackInfo, ISettable
	{
		public object ClientData { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public string RoomName { get; private set; }

		public RTCAudioInputStatus Status { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(AudioInputStateCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
