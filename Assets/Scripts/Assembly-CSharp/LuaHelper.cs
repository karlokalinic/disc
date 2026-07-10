using PixelCrushers.DialogueSystem;

public static class LuaHelper
{
	public static void DefineLuaDatabaseStartupScript(DialogueDatabase db)
	{
	}

	public static string GetLuaDatabaseStartupScript()
	{
		return null;
	}

	public static void SetTableValue(string table, string element, object value)
	{
	}

	public static void SetTableField(string table, string element, string field, object value)
	{
	}

	public static bool DoesVariableExist(string variableName)
	{
		return false;
	}

	public static void SetVariable(string variableName, object value)
	{
	}

	public static bool GetVariable(string variableName)
	{
		return false;
	}

	public static int GetIntVariable(string variableName)
	{
		return 0;
	}

	public static Lua.Result GetTableValue(string table, string element)
	{
		return default(Lua.Result);
	}

	public static int GetTableFieldAsInt(string table, string element, string field, int defaultValue = 0)
	{
		return 0;
	}

	public static bool GetTableFieldAsBool(string table, string element, string field)
	{
		return false;
	}

	private static object GetTableField(string table, string element, string field)
	{
		return null;
	}

	public static string FormatLuaValue(object value)
	{
		return null;
	}
}
