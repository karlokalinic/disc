namespace Language.Lua
{
	public class LuaString : LuaValue
	{
		public static readonly LuaString Empty;

		public string Text { get; set; }

		public override object Value => null;

		public LuaString(string text)
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
