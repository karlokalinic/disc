namespace Language.Lua
{
	public class LuaUserdata : LuaValue
	{
		private object Object;

		public override object Value => null;

		public LuaTable MetaTable { get; set; }

		public LuaUserdata(object obj)
		{
		}

		public LuaUserdata(object obj, LuaTable metatable)
		{
		}

		public override string GetTypeCode()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
