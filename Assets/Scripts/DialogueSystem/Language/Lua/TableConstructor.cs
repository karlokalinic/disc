using System.Collections.Generic;

namespace Language.Lua
{
	public class TableConstructor : Term
	{
		public List<Field> FieldList;

		public override LuaValue Evaluate(LuaTable enviroment)
		{
			return null;
		}
	}
}
