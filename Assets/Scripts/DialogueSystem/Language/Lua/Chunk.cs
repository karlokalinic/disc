using System.Collections.Generic;

namespace Language.Lua
{
	public class Chunk
	{
		public LuaTable Enviroment;

		public List<Statement> Statements;

		public LuaValue Execute()
		{
			return null;
		}

		public LuaValue Execute(LuaTable enviroment, out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}

		public LuaValue Execute(out bool isBreak)
		{
			isBreak = default(bool);
			return null;
		}
	}
}
