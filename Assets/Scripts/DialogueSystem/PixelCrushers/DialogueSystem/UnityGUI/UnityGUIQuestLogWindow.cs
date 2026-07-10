using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class UnityGUIQuestLogWindow : QuestLogWindow
	{
		[Serializable]
		public class AbandonControls
		{
			public GUIControl panel;

			public GUILabel questTitleLabel;

			public GUIButton ok;

			public GUIButton cancel;
		}

		public GUIRoot guiRoot;

		public GUIScrollView scrollView;

		public GUIButton activeButton;

		public GUIButton completedButton;

		public AbandonControls abandonQuestPopup;

		public string groupHeadingGuiStyleName;

		public string questHeadingGuiStyleName;

		public string questHeadingOpenGuiStyleName;

		public string questBodyGuiStyleName;

		public string questEntryActiveGuiStyleName;

		public string questEntrySuccessGuiStyleName;

		public string questEntryFailureGuiStyleName;

		public string questEntryButtonStyleName;

		public string noQuestsGuiStyleName;

		public int padding;

		private GUIStyle groupHeadingStyle;

		private GUIStyle questHeadingStyle;

		private GUIStyle questHeadingOpenStyle;

		private GUIStyle questBodyStyle;

		private GUIStyle questEntryActiveStyle;

		private GUIStyle questEntrySuccessStyle;

		private GUIStyle questEntryFailureStyle;

		private GUIStyle questButtonStyle;

		private Action confirmAbandonQuestHandler;

		private List<string> collapsedGroups;

		public override void Awake()
		{
		}

		public void Start()
		{
		}

		public override void OpenWindow(Action openedWindowHandler)
		{
		}

		public override void CloseWindow(Action closedWindowHandler)
		{
		}

		public override void ConfirmAbandonQuest(string title, Action confirmAbandonQuestHandler)
		{
		}

		private void OpenAbandonQuestPopup(string title)
		{
		}

		private void CloseAbandonQuestPopup()
		{
		}

		public void ClickConfirmAbandonQuest(object data)
		{
		}

		public void ClickCancelAbandonQuest(object data)
		{
		}

		public void OnMeasureContent()
		{
		}

		public void OnDrawContent()
		{
		}

		private void MeasureQuestContent()
		{
		}

		public override void OnQuestListUpdated()
		{
		}

		private GUIStyle UseGUIStyle(GUIStyle guiStyle, string guiStyleName, GUIStyle defaultStyle)
		{
			return null;
		}

		private GUIStyle GetGroupHeadingStyle()
		{
			return null;
		}

		private GUIStyle GetQuestHeadingStyle(bool isSelectedQuest)
		{
			return null;
		}

		private GUIStyle GetQuestEntryStyle(QuestState entryState)
		{
			return null;
		}

		private float GroupHeadingHeight(string group)
		{
			return 0f;
		}

		private float QuestHeadingHeight(QuestInfo questInfo)
		{
			return 0f;
		}

		private float QuestDescriptionHeight(QuestInfo questInfo)
		{
			return 0f;
		}

		private float QuestEntriesHeight(QuestInfo questInfo)
		{
			return 0f;
		}

		private float QuestButtonsHeight(QuestInfo questInfo)
		{
			return 0f;
		}

		private void DrawQuests()
		{
		}

		private float DrawQuestDescription(QuestInfo questInfo, float contentY)
		{
			return 0f;
		}

		private float DrawQuestEntries(QuestInfo questInfo, float contentY)
		{
			return 0f;
		}

		private float DrawQuestButtons(QuestInfo questInfo, float contentY)
		{
			return 0f;
		}

		private void ClickQuestGroup(string group)
		{
		}
	}
}
