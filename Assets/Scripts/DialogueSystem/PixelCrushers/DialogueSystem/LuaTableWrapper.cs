using System.Collections.Generic;
using Language.Lua;

namespace PixelCrushers.DialogueSystem
{
	public class LuaTableWrapper
	{
		public LuaTable luaTable;

		public bool isValid => false;

		public int count => 0;

		public IEnumerable<string> keys => null;

		public IEnumerable<object> values => null;

		public bool IsValid => false;

		public int Count => 0;

		public IEnumerable<string> Keys => null;

		public IEnumerable<object> Values => null;

		public object this[int index] => null;

		public object this[string key] => null;

		public LuaTableWrapper(LuaTable luaTable)
		{
		}
	}
}
