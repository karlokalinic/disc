namespace Language.Lua
{
	public class ForStmt : Statement
	{
		public string VarName;

		public Expr Start;

		public Expr End;

		public Expr Step;

		public Chunk Body;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
