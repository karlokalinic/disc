namespace Language.Lua
{
	public class LuaFunction : LuaValue
	{
		public LuaFunc Function { get; set; }

		public override object Value => null;

		public LuaFunction(LuaFunc function)
		{
		}

		public override string GetTypeCode()
		{
			return null;
		}

		public LuaValue Invoke(LuaValue[] args)
		{
			return null;
		}
	}
}
