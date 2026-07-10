namespace Epic.OnlineServices.AntiCheatClient
{
	public class OnMessageToServerCallbackInfo : ICallbackInfo, ISettable
	{
		public object ClientData { get; private set; }

		public byte[] MessageData { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnMessageToServerCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
