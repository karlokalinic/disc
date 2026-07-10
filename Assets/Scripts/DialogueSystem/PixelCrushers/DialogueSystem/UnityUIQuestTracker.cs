using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIQuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1
		}

		public string playerPrefsToggleKey;

		public Transform container;

		public bool showContainerIfEmpty;

		public UnityUIQuestTrackTemplate questTrackTemplate;

		public bool showActiveQuests;

		public bool showCompletedQuests;

		public bool showCompletedEntryText;

		public QuestDescriptionSource questDescriptionSource;

		public bool visibleOnStart;

		protected List<UnityUIQuestTrackTemplate> instantiatedItems;

		protected List<UnityUIQuestTrackTemplate> unusedInstances;

		protected int siblingIndexCounter;

		protected bool isVisible;

		protected Coroutine refreshCoroutine;

		public virtual void Start()
		{
		}

		public virtual void ShowTracker()
		{
		}

		public virtual void HideTracker()
		{
		}

		public virtual void ToggleTracker()
		{
		}

		public virtual void OnQuestTrackingEnabled(string quest)
		{
		}

		public virtual void OnQuestTrackingDisabled(string quest)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public virtual void UpdateTracker()
		{
		}

		protected virtual IEnumerator RefreshAtEndOfFrame()
		{
			return null;
		}

		protected virtual void AddQuestTrack(string quest)
		{
		}

		protected virtual string GetQuestEntryText(string quest, int entryNum, QuestState entryState)
		{
			return null;
		}
	}
}
