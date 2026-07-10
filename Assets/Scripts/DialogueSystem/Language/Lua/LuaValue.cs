using System;

namespace Language.Lua
{
	public abstract class LuaValue : IEquatable<LuaValue>
	{
		public abstract object Value { get; }

		public abstract string GetTypeCode();

		public virtual bool GetBooleanValue()
		{
			return false;
		}

		public bool Equals(LuaValue other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static LuaValue GetKeyValue(LuaValue baseValue, LuaValue key)
		{
			return null;
		}
	}
}
