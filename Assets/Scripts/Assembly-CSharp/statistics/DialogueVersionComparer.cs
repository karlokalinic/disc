using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.Articy;
using UnityEngine;

namespace statistics
{
	[CreateAssetMenu]
	public class DialogueVersionComparer : ScriptableObject
	{
		private const string VARIABLES_FILE_NAME = "DVC_Variables";

		private const string DIALOGUES_FILE_NAME = "DVC_Dialogues";

		[TextArea]
		public string File1Location;

		[TextArea]
		public string File2Location;

		public static DialogueComparerFileWriter fileWriter;

		public void Compare()
		{
		}

		public static ArticyData ParseArticyData(string fileName)
		{
			return null;
		}

		private bool ValidateInput()
		{
			return false;
		}

		public static bool RemoveIfPresentInBoth(List<string> list1, List<string> list2, string value)
		{
			return false;
		}

		public static void CompareValue(string identifier, string value1, string value2, List<string> path)
		{
		}

		public static void CompareValue(string identifier, IConvertible value1, IConvertible value2, List<string> path)
		{
		}

		public static void CompareValue(string identifier, Vector2 value1, Vector2 value2, List<string> path)
		{
		}

		public static void OutputMissingElements(string identifier, List<string> list1, List<string> list2, List<string> path)
		{
		}
	}
}
