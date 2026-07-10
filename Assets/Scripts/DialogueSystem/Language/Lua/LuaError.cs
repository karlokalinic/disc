using System;

namespace Language.Lua
{
	public class LuaError : Exception
	{
		public LuaError(string message)
		{
		}

		public LuaError(string message, Exception innerException)
		{
		}

		public LuaError(string messageformat, params object[] args)
		{
		}
	}
}
