using System.Collections.Generic;

namespace Language.Lua
{
	public class OperTable
	{
		private static Dictionary<string, int> precedence;

		private static Associativity[] associativity;

		static OperTable()
		{
		}

		public static bool Contains(string oper)
		{
			return false;
		}

		public static bool IsPrior(string operLeft, string operRight)
		{
			return false;
		}
	}
}
