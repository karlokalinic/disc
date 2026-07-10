namespace Language.Lua
{
	public class LocalFunc : Statement
	{
		public string Name;

		public FunctionBody Body;

		public override LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
