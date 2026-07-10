namespace Language.Lua
{
	public class Function : Statement
	{
		public FunctionName Name;

		public FunctionBody Body;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
