namespace Language.Lua
{
	public class LuaNil : LuaValue
	{
		public static readonly LuaNil Nil;

		public override object Value => null;

		private LuaNil()
		{
		}

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
	}
}
