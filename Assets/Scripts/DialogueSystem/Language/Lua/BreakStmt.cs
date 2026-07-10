namespace Language.Lua
{
	public class BreakStmt : Statement
	{
		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
