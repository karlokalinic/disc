using System.Collections.Generic;

namespace Language.Lua
{
	public class ReturnStmt : Statement
	{
		public List<Expr> ExprList;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
