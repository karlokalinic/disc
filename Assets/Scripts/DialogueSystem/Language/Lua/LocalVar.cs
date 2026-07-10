using System.Collections.Generic;

namespace Language.Lua
{
	public class LocalVar : Statement
	{
		public List<string> NameList;

		public List<Expr> ExprList;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
