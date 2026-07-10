namespace Epic.OnlineServices.KWS
{
	public class RequestPermissionsCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public ProductUserId LocalUserId { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(RequestPermissionsCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
