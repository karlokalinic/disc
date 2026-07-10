namespace Epic.OnlineServices.KWS
{
	public class QueryAgeGateCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public object ClientData { get; private set; }

		public string CountryCode { get; private set; }

		public uint AgeOfConsent { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(QueryAgeGateCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
