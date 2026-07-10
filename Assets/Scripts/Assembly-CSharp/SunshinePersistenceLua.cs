using System.Collections.Generic;
using System.Text;
using PixelCrushers.DialogueSystem;

public static class SunshinePersistenceLua
{
	public static void SerializeTableWithFields(StringBuilder sb, string tableName, string tableReplacementName = null)
	{
	}

	public static void SerializeTableWithFieldsAndProperties(StringBuilder sb, string tableName)
	{
	}

	public static void AppendPropertiesToLuaTable(StringBuilder sb, string tableName, object fieldName, Dictionary<string, object> properties)
	{
	}

	public static string SerializePropertyMap(Dictionary<string, object> properties)
	{
		return null;
	}

	public static void SerializePropertyMap(Dictionary<string, object> properties, StringBuilder sb, bool brace = true)
	{
	}

	public static void Brace(StringBuilder sb)
	{
	}

	private static void SerializeProperty(string key, object value, StringBuilder sb)
	{
	}

	public static void AppendValueToLuaTable(StringBuilder sb, string tableName, object fieldName, object value)
	{
	}

	public static void AppendValueToLua(StringBuilder sb, string tableName, object value)
	{
	}

	public static string SerializeList(List<string> list)
	{
		return null;
	}

	private static bool IsKeyUsable(string key)
	{
		return false;
	}

	public static Lua.Result GetFieldValueFromTable(string tableName, string fieldName)
	{
		return default(Lua.Result);
	}

	public static int ToInt(object value)
	{
		return 0;
	}

	public static void DebugPrintOut(string luaTableName)
	{
	}

	public static void DebugPrintOut(StringBuilder sb, LuaTableWrapper luaTable, int level)
	{
	}
}
