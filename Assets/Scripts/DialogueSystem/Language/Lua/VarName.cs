namespace Language.Lua
{
	public class VarName : BaseExpr
	{
		public string Name;

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
