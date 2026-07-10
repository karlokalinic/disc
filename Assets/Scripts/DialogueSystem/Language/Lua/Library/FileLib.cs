using System.IO;

namespace Language.Lua.Library
{
	public static class FileLib
	{
		public static void RegisterModule(LuaTable enviroment)
		{
		}

		public static void RegisterFunctions(LuaTable module)
		{
		}

		public static LuaTable CreateMetaTable()
		{
			return null;
		}

		public static LuaValue close(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue read(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue lines(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue seek(LuaValue[] values)
		{
			return null;
		}

		private static SeekOrigin GetSeekOrigin(string whence)
		{
			return default(SeekOrigin);
		}

		public static LuaValue write(LuaValue[] values)
		{
			return null;
		}

		public static LuaValue flush(LuaValue[] values)
		{
			return null;
		}
	}
}
