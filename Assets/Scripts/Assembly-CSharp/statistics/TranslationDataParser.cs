using System.Collections.Generic;
using System.IO;
using PixelCrushers.DialogueSystem.Articy;
using UnityEngine;

namespace statistics
{
	[CreateAssetMenu]
	public class TranslationDataParser : ScriptableObject
	{
		private const string VARIABLES_FILE_NAME = "Translation - ";

		[TextArea]
		public string XMLFileLocation;

		public string CSVFileLocation;

		public string DialogueArticyID;

		private ArticyData.Node dialogueNode;

		private ArticyData articyData;

		private StreamWriter file;

		private Dictionary<string, string> translatedTextDictionary;

		public void Export()
		{
		}

		private void ExportToCSV(ArticyData articyData)
		{
		}

		private void PrintNode(ArticyData.Node node)
		{
		}

		private void WriteDialogueFragmentToCSV(ArticyData.Node node)
		{
		}

		private void WriteDialogueToCSV(ArticyData.Node node)
		{
		}

		private void WriteHeader()
		{
		}

		private void WriteCSVLine(string id, string actor, string title, string text)
		{
		}

		private void FindNodeByArticyId(ArticyData.Node node)
		{
		}

		private bool ValidateInput()
		{
			return false;
		}

		public void Import()
		{
		}
	}
}
