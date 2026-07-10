namespace Language.Lua
{
	public class MethodCall : Access
	{
		public string Method;

		public Args Args;

		public override LuaValue Evaluate(LuaValue baseValue, LuaTable enviroment)
		{
			return null;
		}
	}
}
