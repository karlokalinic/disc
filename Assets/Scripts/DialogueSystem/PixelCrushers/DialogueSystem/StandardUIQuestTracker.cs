using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIQuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1
		}

		public string playerPrefsToggleKey;

		public Transform container;

		public bool showContainerIfEmpty;

		public StandardUIQuestTrackTemplate questTrackTemplate;

		public bool showActiveQuests;

		public bool showCompletedQuests;

		public bool showCompletedEntryText;

		public QuestDescriptionSource questDescriptionSource;

		public bool visibleOnStart;

		protected List<StandardUIQuestTrackTemplate> instantiatedItems;

		private List<StandardUIQuestTrackTemplate> unusedInstances;

		private int siblingIndexCounter;

		protected bool m_started;

		protected bool isVisible;

		protected Coroutine refreshCoroutine;

		public virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void RegisterForUpdateTrackerEvents()
		{
		}

		protected void UnregisterFromUpdateTrackerEvents()
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
