using System.Collections.Generic;
using System.IO;
using PixelCrushers.DialogueSystem;

namespace statistics
{
	public static class VariableStatisticsCollector
	{
		private const string FILE_NAME = "Variables";

		private static List<string> excludedPrefixes;

		private static Dictionary<string, List<string>> variables;

		private static Dictionary<string, List<string>> variableSettings;

		public static void CollectStatistics(DialogueDatabase ntwtfDD)
		{
		}

		private static void ClearAndInit(DialogueDatabase ntwtfDD)
		{
		}

		private static void CollectReferences(DialogueDatabase ntwtfDD, StreamWriter file)
		{
		}

		private static void CheckExpression(string expression, string title, StreamWriter file)
		{
		}

		private static void Parse(string variable, string userScript, string dialogueTitle, StreamWriter file)
		{
		}

		private static void OutputUsages(StreamWriter file)
		{
		}
	}
}
