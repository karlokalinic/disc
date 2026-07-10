using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class QuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1
		}

		private class QuestTrackerLine
		{
			public string guiStyleName;

			public GUIStyle guiStyle;

			public string text;
		}

		public string playerPrefsToggleKey;

		public ScaledRect rect;

		public GUISkin guiSkin;

		public string TitleStyle;

		public string SuccessTitleStyle;

		public string FailureTitleStyle;

		public string ActiveEntryStyle;

		public string SuccessEntryStyle;

		public string FailureEntryStyle;

		public bool showActiveQuests;

		public bool showCompletedQuests;

		public bool showCompletedEntryText;

		public QuestDescriptionSource questDescriptionSource;

		private Rect screenRect;

		private List<QuestTrackerLine> lines;

		private bool isVisible;

		public void Start()
		{
		}

		private IEnumerator UpdateTrackerAfterOneFrame()
		{
			return null;
		}

		public void ShowTracker()
		{
		}

		public void HideTracker()
		{
		}

		public void ToggleTracker()
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

		private void AddQuestTitle(string quest)
		{
		}

		private void AddQuestEntries(string quest)
		{
		}

		private string GetQuestEntryText(string quest, int entryNum, QuestState entryState)
		{
			return null;
		}

		private string GetTitleStyleName(QuestState state)
		{
			return null;
		}

		private string GetEntryStyleName(QuestState entryState)
		{
			return null;
		}

		private void OnGUI()
		{
		}
	}
}
