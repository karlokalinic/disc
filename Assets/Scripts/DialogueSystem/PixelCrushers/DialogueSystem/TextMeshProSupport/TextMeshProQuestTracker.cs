using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProQuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1
		}

		public Transform container;

		public bool showContainerIfEmpty;

		public TextMeshProQuestTrackTemplate questTrackTemplate;

		public bool showActiveQuests;

		public bool showCompletedQuests;

		public bool showCompletedEntryText;

		public QuestDescriptionSource questDescriptionSource;

		private List<GameObject> instantiatedItems;

		public void Start()
		{
		}

		public void OnQuestTrackingEnabled(string quest)
		{
		}

		public void OnQuestTrackingDisabled(string quest)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void UpdateTracker()
		{
		}

		public void DestroyInstantiatedItems()
		{
		}

		private void InstantiateQuestTrack(string quest)
		{
		}

		private string GetQuestEntryText(string quest, int entryNum, QuestState entryState)
		{
			return null;
		}
	}
}
