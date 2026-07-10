using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIQuestTrackTemplate : MonoBehaviour
	{
		public UITextField description;

		public StandardUIQuestTemplateAlternateDescriptions alternateDescriptions;

		public Transform entryContainer;

		public UITextField entryDescription;

		public StandardUIQuestTemplateAlternateDescriptions alternateEntryDescriptions;

		private List<GameObject> m_instances;

		private int numEntries;

		public bool arePropertiesAssigned => false;

		public void Initialize()
		{
		}

		public void SetDescription(string text, QuestState questState)
		{
		}

		private void SetFirstValidTextElement(string text, params UITextField[] textElements)
		{
		}

		public void AddEntryDescription(string text, QuestState entryState)
		{
		}

		private void InstantiateFirstValidTextElement(string text, Transform container, params UITextField[] textElements)
		{
		}
	}
}
