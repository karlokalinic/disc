namespace Language.Lua
{
	public class NameAccess : Access
	{
		public string Name;

		public override LuaValue Evaluate(LuaValue baseValue, LuaTable enviroment)
		{
			return null;
		}
	}
}
