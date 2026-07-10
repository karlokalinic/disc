namespace Language.Lua
{
	public class Operation : Term
	{
		public string Operator;

		public Term LeftOperand;

		public Term RightOperand;

		public Operation(string oper)
		{
		}

		public Operation(string oper, Term left, Term right)
		{
		}

		public override LuaValue Evaluate(LuaTable enviroment)
		{
			return null;
		}

		private LuaValue PrefixUnaryOperation(string Operator, Term RightOperand, LuaTable enviroment)
		{
			return null;
		}

		private LuaValue InfixBinaryOperation(Term LeftOperand, string Operator, Term RightOperand, LuaTable enviroment)
		{
			return null;
		}

		private static int? Compare(LuaValue leftValue, LuaValue rightValue)
		{
			return null;
		}

		private static LuaFunction GetMetaFunction(string name, LuaValue leftValue, LuaValue rightValue)
		{
			return null;
		}
	}
}
