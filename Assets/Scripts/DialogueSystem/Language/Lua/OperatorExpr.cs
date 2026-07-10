using System.Collections.Generic;

namespace Language.Lua
{
	public class OperatorExpr : Expr
	{
		public LinkedList<object> Terms;

		public void Add(string oper)
		{
		}

		public void Add(Term term)
		{
		}

		public Term BuildExpressionTree()
		{
			return null;
		}

		private static Term BuildExpressionTree(Term leftTerm, LinkedListNode<object> node)
		{
			return null;
		}

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
