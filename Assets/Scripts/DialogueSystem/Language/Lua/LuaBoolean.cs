namespace Language.Lua
{
	public class LuaBoolean : LuaValue
	{
		public static readonly LuaBoolean False;

		public static readonly LuaBoolean True;

		public bool BoolValue { get; set; }

		public override object Value => null;

		public override string GetTypeCode()
		{
			return null;
		}

		public override bool GetBooleanValue()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		private LuaBoolean()
		{
		}

		public static LuaBoolean From(bool value)
		{
			return null;
		}
	}
}
