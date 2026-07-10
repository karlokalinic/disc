namespace Epic.OnlineServices.RTCAdmin
{
	public class QueryJoinRoomTokenCompleteCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public string RoomName { get; private set; }

		public string ClientBaseUrl { get; private set; }

		public uint QueryId { get; private set; }

		public uint TokenCount { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(QueryJoinRoomTokenCompleteCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
