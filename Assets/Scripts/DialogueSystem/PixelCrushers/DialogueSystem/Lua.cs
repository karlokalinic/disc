using System.Reflection;
using Language.Lua;

namespace PixelCrushers.DialogueSystem
{
	public sealed class Lua
	{
		public struct Result
		{
			public LuaValue luaValue;

			public LuaTableWrapper luaTableWrapper;

			public bool hasReturnValue => false;

			public string asString => null;

			public bool asBool => false;

			public float asFloat => 0f;

			public int asInt => 0;

			public LuaTableWrapper asTable => null;

			public bool isString => false;

			public bool isBool => false;

			public bool isNumber => false;

			public bool isTable => false;

			public bool HasReturnValue => false;

			public string AsString => null;

			public bool AsBool => false;

			public float AsFloat => 0f;

			public int AsInt => 0;

			public LuaTableWrapper AsTable => null;

			public bool IsString => false;

			public bool IsBool => false;

			public bool IsNumber => false;

			public bool IsTable => false;

			public Result(LuaValue luaValue)
			{
				this.luaValue = null;
				luaTableWrapper = null;
			}
		}

		public static readonly Result noResult;

		private static LuaTable m_environment;

		public static Result NoResult => default(Result);

		public static bool wasInvoked { get; set; }

		public static bool muteExceptions { get; set; }

		public static bool warnRegisteringExistingFunction { get; set; }

		public static LuaTable environment => null;

		public static LuaTable Environment => null;

		public static bool WasInvoked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool MuteExceptions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool WarnRegisteringExistingFunction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static Result Run(string luaCode, bool debug, bool allowExceptions)
		{
			return default(Result);
		}

		public static Result Run(string luaCode, bool debug)
		{
			return default(Result);
		}

		public static Result Run(string luaCode)
		{
			return default(Result);
		}

		public static bool IsTrue(string luaCondition, bool debug, bool allowExceptions)
		{
			return false;
		}

		public static bool IsTrue(string luaCondition, bool debug)
		{
			return false;
		}

		public static bool IsTrue(string luaCondition)
		{
			return false;
		}

		public static LuaValue RunRaw(string luaCode, bool debug, bool allowExceptions)
		{
			return null;
		}

		public static LuaValue RunRaw(string luaCode, bool debug)
		{
			return null;
		}

		public static LuaValue RunRaw(string luaCode)
		{
			return null;
		}

		public static void RegisterFunction(string functionName, object target, MethodInfo method)
		{
		}

		public static void UnregisterFunction(string functionName)
		{
		}
	}
}
