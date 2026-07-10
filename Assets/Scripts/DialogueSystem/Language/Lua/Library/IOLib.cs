using System.IO;

namespace Language.Lua.Library
{
	public static class IOLib
	{
		private static TextReader DefaultInput;

		private static TextWriter DefaultOutput;

		public static void RegisterModule(LuaTable enviroment)
		{
		}

		public static void RegisterFunctions(LuaTable module)
		{
		}

		public static LuaValue input(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue output(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue open(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue read(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue write(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue flush(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue tmpfile(LuaValue[] values)
		{
			return null;
		}
	}
}
