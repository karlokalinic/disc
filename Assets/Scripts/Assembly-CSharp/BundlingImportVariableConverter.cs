using System.Collections.Generic;
using PixelCrushers.DialogueSystem.Articy;

public static class BundlingImportVariableConverter
{
	private static readonly string LATEST_CACHE_VERSION;

	public static readonly List<string> UNCONVERTABLE_FIELD_NAMES;

	private static Dictionary<string, List<string>> variables;

	private static int shortestVariableLength;

	private static SortedDictionary<string, string> oldCache;

	private static SortedDictionary<string, string> newCache;

	private const string CACHE_FILE_NAME = "XmlImportCache";

	private const string CACHE_FILE_EXTENSION = ".json";

	public static void InitConverter(Dictionary<string, ArticyData.VariableSet> variableSets)
	{
	}

	private static void ResetArticyConverterVariables()
	{
	}

	private static void DeleteCacheIfExpired()
	{
	}

	public static string ParseExpression(string expression)
	{
		return null;
	}

	private static string PrepareForArticyConverterAndConvert(string expression)
	{
		return null;
	}

	private static string DoVariableReplacements(string expression, string variable)
	{
		return null;
	}

	private static bool IsTokenQuoted(string value, string token, int index)
	{
		return false;
	}

	private static void InitializeVariables(Dictionary<string, ArticyData.VariableSet> variableSets)
	{
	}

	public static void FinalizeConverter()
	{
	}

	private static string GetCurrentVersionCacheFileName()
	{
		return null;
	}
}
