using TMPro;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProQuestTrackTemplate : MonoBehaviour
	{
		public TextMeshProUGUI description;

		public TextMeshProQuestTemplateAlternateDescriptions alternateDescriptions;

		public Transform entryContainer;

		public TextMeshProUGUI entryDescription;

		public TextMeshProQuestTemplateAlternateDescriptions alternateEntryDescriptions;

		private int numEntries;

		public bool ArePropertiesAssigned => false;

		public void Initialize()
		{
		}

		public void SetDescription(string text, QuestState questState)
		{
		}

		private void SetFirstValidTextElement(string text, params TextMeshProUGUI[] textElements)
		{
		}

		public void AddEntryDescription(string text, QuestState entryState)
		{
		}

		private void InstantiateFirstValidTextElement(string text, Transform container, params TextMeshProUGUI[] textElements)
		{
		}
	}
}
