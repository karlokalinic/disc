using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIQuestTemplate : MonoBehaviour
	{
		public Button heading;

		public Text description;

		public UnityUIQuestTemplateAlternateDescriptions alternateDescriptions;

		public Transform entryContainer;

		public Text entryDescription;

		public UnityUIQuestTemplateAlternateDescriptions alternateEntryDescriptions;

		public Button trackButton;

		public Button abandonButton;

		protected List<GameObject> entryInstances;

		protected int numEntries;

		public bool ArePropertiesAssigned => false;

		public virtual void Initialize()
		{
		}

		public virtual void ClearQuestDetails()
		{
		}

		public virtual void AddEntryDescription(string text, QuestState entryState)
		{
		}

		protected void InstantiateFirstValidTextElement(string text, Transform container, params Text[] textElements)
		{
		}
	}
}
