using System.Collections.Generic;
using System.Reflection;

namespace Language.Lua
{
	public class LuaTable : LuaValue
	{
		private List<LuaValue> list;

		private Dictionary<LuaValue, LuaValue> dict;

		private Dictionary<int, LuaValue> m_intKeyCache;

		private Dictionary<string, LuaValue> m_stringKeyCache;

		public LuaTable MetaTable { get; set; }

		public override object Value => null;

		public int Length => 0;

		public int Count => 0;

		public List<LuaValue> List => null;

		public Dictionary<LuaValue, LuaValue> Dict => null;

		public IEnumerable<LuaValue> ListValues => null;

		public IEnumerable<LuaValue> Keys => null;

		public IEnumerable<KeyValuePair<LuaValue, LuaValue>> KeyValuePairs => null;

		public LuaTable()
		{
		}

		public LuaTable(LuaTable parent)
		{
		}

		public override string GetTypeCode()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public void AddRaw(string key, LuaValue value)
		{
		}

		public void AddRaw(int key, LuaValue value)
		{
		}

		public bool ContainsKey(LuaValue key)
		{
			return false;
		}

		public void AddValue(LuaValue value)
		{
		}

		public void InsertValue(int index, LuaValue value)
		{
		}

		public bool Remove(LuaValue item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		public void Sort()
		{
		}

		public void Sort(LuaFunction compare)
		{
		}

		public LuaValue GetValue(int index)
		{
			return null;
		}

		public LuaValue GetValue(string name)
		{
			return null;
		}

		public LuaValue GetKey(string key)
		{
			return null;
		}

		public void SetNameValue(string name, LuaValue value)
		{
		}

		private void RemoveKey(string name)
		{
		}

		public void SetKeyValue(LuaValue key, LuaValue value)
		{
		}

		private bool GetIntValue(LuaValue value, out int intValue)
		{
			intValue = default(int);
			return false;
		}

		private void RemoveKey(LuaValue key)
		{
		}

		public LuaValue GetValue(LuaValue key)
		{
			return null;
		}

		private LuaValue GetValueFromMetaTable(string name)
		{
			return null;
		}

		private LuaValue GetValueFromMetaTable(LuaValue key)
		{
			return null;
		}

		public LuaFunction Register(string name, LuaFunc function)
		{
			return null;
		}

		public LuaFunction RegisterMethodFunction(string name, object target, MethodInfo methodInfo)
		{
			return null;
		}

		public LuaValue RawGetValue(LuaValue key)
		{
			return null;
		}

		public void RawSetValue(string name, LuaValue value)
		{
		}
	}
}
