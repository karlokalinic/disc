namespace Epic.OnlineServices.AntiCheatCommon
{
	public class LogEventParamPair : ISettable
	{
		public LogEventParamPairParamValue ParamValue { get; set; }

		internal void Set(LogEventParamPairInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
