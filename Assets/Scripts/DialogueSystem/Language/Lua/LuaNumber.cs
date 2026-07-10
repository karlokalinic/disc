namespace Language.Lua
{
	public class LuaNumber : LuaValue
	{
		public double Number { get; set; }

		public override object Value => null;

		public LuaNumber(double number)
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
