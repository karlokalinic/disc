using System.Collections.Generic;

namespace Language.Lua
{
	public class Assignment : Statement
	{
		public List<Var> VarList;

		public List<Expr> ExprList;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}

		private static void SetKeyValue(LuaValue baseValue, LuaValue key, LuaValue value)
		{
		}
	}
}
