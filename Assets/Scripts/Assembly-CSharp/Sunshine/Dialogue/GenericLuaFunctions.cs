using System;

namespace Sunshine.Dialogue
{
	public static class GenericLuaFunctions
	{
		public static Action<string> OnLuaVariableChanged;

		public const string SET_VARIABLE_METHOD = "SetVariableValue";

		public const string VARIABLE_LUA_TABLE = "Variable";

		public static void Register()
		{
		}

		public static void InitTables()
		{
		}

		public static void SetVariableValue(string variableName, object newValue)
		{
		}

		public static double once(double value)
		{
			return 0.0;
		}

		public static double Once(double value)
		{
			return 0.0;
		}

		public static bool not(bool value)
		{
			return false;
		}

		public static bool LuaTestFunction()
		{
			return false;
		}

		public static bool ChancePercentage(double val)
		{
			return false;
		}

		public static void DestroyObject(string name)
		{
		}

		public static void AutoSave()
		{
		}

		public static void ResetCameraMarker()
		{
		}

		public static void ClearAllInputLocks()
		{
		}

		public static void ApplyCharacterScheduleConditions(string scheduleName)
		{
		}
	}
}
