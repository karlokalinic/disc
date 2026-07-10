using System.Collections.Generic;

namespace Language.Lua
{
	public class IfStmt : Statement
	{
		public Expr Condition;

		public Chunk ThenBlock;

		public List<ElseifBlock> ElseifBlocks;

		public Chunk ElseBlock;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
