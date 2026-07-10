using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIQuestTrackTemplate : MonoBehaviour
	{
		public Text description;

		public UnityUIQuestTemplateAlternateDescriptions alternateDescriptions;

		public Transform entryContainer;

		public Text entryDescription;

		public UnityUIQuestTemplateAlternateDescriptions alternateEntryDescriptions;

		private List<Text> instances;

		private int numEntries;

		public bool ArePropertiesAssigned => false;

		public void Initialize()
		{
		}

		public void SetDescription(string text, QuestState questState)
		{
		}

		private void SetFirstValidTextElement(string text, params Text[] textElements)
		{
		}

		public void AddEntryDescription(string text, QuestState entryState)
		{
		}

		private void InstantiateFirstValidTextElement(string text, Transform container, params Text[] textElements)
		{
		}
	}
}
