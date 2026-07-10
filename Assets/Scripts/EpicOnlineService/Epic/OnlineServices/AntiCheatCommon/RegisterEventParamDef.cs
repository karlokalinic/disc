namespace Epic.OnlineServices.AntiCheatCommon
{
	public class RegisterEventParamDef : ISettable
	{
		public string ParamName { get; set; }

		public AntiCheatCommonEventParamType ParamType { get; set; }

		internal void Set(RegisterEventParamDefInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
