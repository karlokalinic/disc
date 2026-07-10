namespace Language.Lua
{
	public class RepeatStmt : Statement
	{
		public Chunk Body;

		public Expr Condition;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
