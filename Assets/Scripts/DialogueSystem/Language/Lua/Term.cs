namespace Language.Lua
{
	public class Term : Expr
	{
		public override LuaValue Evaluate(LuaTable enviroment)
		{
			return null;
		}

		public override Term Simplify()
		{
			return null;
		}
	}
}
