using System.Collections.Generic;

namespace Language.Lua
{
	public class PrimaryExpr : Term
	{
		public BaseExpr Base;

		public List<Access> Accesses;

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
