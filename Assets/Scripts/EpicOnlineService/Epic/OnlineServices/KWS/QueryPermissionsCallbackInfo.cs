namespace Epic.OnlineServices.KWS
{
	public class QueryPermissionsCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public string KWSUserId { get; private set; }

		public string DateOfBirth { get; private set; }

		public bool IsMinor { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(QueryPermissionsCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
