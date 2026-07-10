using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PixelCrushers.DialogueSystem.Articy
{
	public static class ArticyTools
	{
		public const string SubtableFieldPrefix = "SUBTABLE__";

		public static bool convertMarkupToRichText;

		private static string[] htmlTags;

		private const RegexOptions Options = RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.CultureInvariant;

		private static readonly Regex StylesRegex;

		private static readonly Regex StyleRegex;

		private static readonly Regex BoldRegex;

		private static readonly Regex ItalicRegex;

		private static readonly Regex ColorRegex;

		private static readonly Regex TextRegex;

		private static readonly Regex PartsRegex;

		public static bool DataContainsSchemaId(string xmlData, string schemaId)
		{
			return false;
		}

		public static string RemoveHtml(string s)
		{
			return null;
		}

		private static string ReplaceMarkup(string s)
		{
			return null;
		}

		private static string ConvertToRichText(string s)
		{
			return null;
		}

		private static string ApplyStyle(string innerText, bool bold, bool italic, string color)
		{
			return null;
		}

		private static void WrapInTag(ref StringBuilder builder, string tag, string value = "")
		{
		}

		public static bool IsQuestStateArticyPropertyName(string propertyName)
		{
			return false;
		}

		public static string EnumValueToQuestState(int enumValue, string stringValue)
		{
			return null;
		}

		public static void InitializeLuaSubtables()
		{
		}

		private static void InitializeLuaSubtablesForAsset<T>(string tableName, List<T> assets) where T : Asset
		{
		}

		public static Asset FindAssetByArticyId(string articyId)
		{
			return null;
		}

		private static Asset FindAssetInListByArticyId<T>(List<T> assets, string articyId) where T : Asset
		{
			return null;
		}
	}
}
