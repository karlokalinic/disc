namespace Language.Lua
{
	public class KeyAccess : Access
	{
		public Expr Key;

		public override LuaValue Evaluate(LuaValue baseValue, LuaTable enviroment)
		{
			return null;
		}
	}
}
