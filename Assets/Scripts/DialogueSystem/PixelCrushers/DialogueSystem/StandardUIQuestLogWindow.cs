using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIQuestLogWindow : QuestLogWindow
	{
		public UIPanel mainPanel;

		public UITextField showingActiveQuestsHeading;

		public UITextField showingCompletedQuestHeading;

		public Button activeQuestsButton;

		public Button completedQuestsButton;

		public RectTransform questSelectionContentContainer;

		public StandardUIFoldoutTemplate questGroupTemplate;

		public StandardUIQuestTitleButtonTemplate activeQuestHeadingTemplate;

		public StandardUIQuestTitleButtonTemplate selectedActiveQuestHeadingTemplate;

		public StandardUIQuestTitleButtonTemplate completedQuestHeadingTemplate;

		public StandardUIQuestTitleButtonTemplate selectedCompletedQuestHeadingTemplate;

		public bool showNoQuestsText;

		public bool showDetailsOnSelect;

		public bool keepGroupsExpanded;

		public RectTransform questDetailsContentContainer;

		public StandardUITextTemplate questHeadingTextTemplate;

		public StandardUITextTemplate questDescriptionTextTemplate;

		public StandardUITextTemplate questEntryActiveTextTemplate;

		public StandardUITextTemplate questEntrySuccessTextTemplate;

		public StandardUITextTemplate questEntryFailureTextTemplate;

		public StandardUIButtonTemplate abandonButtonTemplate;

		public UIPanel abandonQuestPanel;

		public UITextField abandonQuestTitleText;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public bool addEventSystemIfNeeded;

		private StandardUIInstancedContentManager m_selectionPanelContentManager;

		private StandardUIInstancedContentManager m_detailsPanelContentManager;

		protected List<string> expandedGroupNames;

		protected Action confirmAbandonQuestHandler;

		private Coroutine m_refreshCoroutine;

		private bool m_isAwake;

		public string foldoutToSelect;

		public string questTitleToSelect;

		protected StandardUIInstancedContentManager selectionPanelContentManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected StandardUIInstancedContentManager detailsPanelContentManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		protected virtual void InitializeTemplates()
		{
		}

		public override void OpenWindow(Action openedWindowHandler)
		{
		}

		public override void CloseWindow(Action closedWindowHandler)
		{
		}

		public virtual void Toggle()
		{
		}

		public virtual bool IsGroupExpanded(string groupName)
		{
			return false;
		}

		public virtual void ToggleGroup(string groupName)
		{
		}

		protected void SetStateToggleButtons()
		{
		}

		public virtual void Repaint()
		{
		}

		private IEnumerator RefreshAtEndOfFrame()
		{
			return null;
		}

		public override void OnQuestListUpdated()
		{
		}

		protected IEnumerator SelectElement(Selectable elementToSelect)
		{
			return null;
		}

		protected virtual void AddShowDetailsOnSelect(Button button, string target)
		{
		}

		protected virtual void OnClickGroup(string groupName, StandardUIFoldoutTemplate groupFoldout)
		{
		}

		protected virtual void ShowDetailsOnSelect(string questTitle)
		{
		}

		protected virtual void OnClickQuest(string questTitle)
		{
		}

		public virtual void SelectQuest(string questTitle)
		{
		}

		protected virtual void RepaintSelectedQuest(QuestInfo quest)
		{
		}

		protected virtual StandardUITextTemplate GetEntryTemplate(QuestState state)
		{
			return null;
		}

		public virtual void OnToggleTracking(bool value, object data)
		{
		}

		public override void ConfirmAbandonQuest(string title, Action confirmAbandonQuestHandler)
		{
		}

		public virtual void AbandonQuestConfirmed()
		{
		}

		protected override void ShowQuests(QuestState questStateMask)
		{
		}
	}
}
