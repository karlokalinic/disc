namespace Language.Lua
{
	public class WhileStmt : Statement
	{
		public Expr Condition;

		public Chunk Body;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
