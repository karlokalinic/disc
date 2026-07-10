using System.Reflection;

namespace Language.Lua
{
	public class LuaMethodFunction : LuaFunction
	{
		public object Target { get; set; }

		public MethodInfo Method { get; set; }

		public LuaMethodFunction(object target, MethodInfo method)
			: base(null)
		{
		}

		public LuaValue InvokeMethod(LuaValue[] args)
		{
			return null;
		}
	}
}
