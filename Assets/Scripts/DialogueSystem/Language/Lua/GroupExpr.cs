namespace Language.Lua
{
	public class GroupExpr : BaseExpr
	{
		public Expr Expr;

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
