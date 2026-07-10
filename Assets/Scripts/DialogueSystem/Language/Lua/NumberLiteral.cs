namespace Language.Lua
{
	public class NumberLiteral : Term
	{
		public string HexicalText;

		public string Text;

		public override LuaValue Evaluate(LuaTable enviroment)
		{
			return null;
		}
	}
}
