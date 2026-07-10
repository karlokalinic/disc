namespace Language.Lua
{
	public class LuaMultiValue : LuaValue
	{
		public LuaValue[] Values { get; set; }

		public override object Value => null;

		public LuaMultiValue(LuaValue[] values)
		{
		}

		public override string GetTypeCode()
		{
			return null;
		}

		public static LuaValue WrapLuaValues(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue[] UnWrapLuaValues(LuaValue[] values)
		{
			return null;
		}

		private static bool ContainsMultiValue(LuaValue[] values)
		{
			return false;
		}
	}
}
