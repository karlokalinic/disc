using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIQuestLogWindow : QuestLogWindow
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;

			public UIShowHideController.TransitionMode transitionMode;

			public bool debug;
		}

		public Graphic mainPanel;

		public Button activeQuestsButton;

		public Button completedQuestsButton;

		public Graphic questTable;

		public UnityUIQuestGroupTemplate questGroupTemplate;

		public UnityUIQuestTemplate questTemplate;

		public Graphic abandonPopup;

		public Text abandonQuestTitle;

		public AnimationTransitions animationTransitions;

		public bool autoFocus;

		public float autoFocusCheckFrequency;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public UnityEvent onContentChanged;

		public bool addEventSystemIfNeeded;

		protected Action confirmAbandonQuestHandler;

		private UIShowHideController m_showHideController;

		protected List<string> collapsedGroups;

		protected List<UnityUIQuestGroupTemplate> groupTemplateInstances;

		protected List<UnityUIQuestTemplate> questTemplateInstances;

		protected List<UnityUIQuestGroupTemplate> unusedGroupTemplateInstances;

		protected List<UnityUIQuestTemplate> unusedQuestTemplateInstances;

		protected int siblingIndexCounter;

		private float nextAutoFocusCheckTime;

		protected UIShowHideController showHideController => null;

		public override void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void Update()
		{
		}

		public override void OpenWindow(Action openedWindowHandler)
		{
		}

		public void AutoFocus()
		{
		}

		public override void CloseWindow(Action closedWindowHandler)
		{
		}

		public override void OnQuestListUpdated()
		{
		}

		protected void SetStateButtonListeners()
		{
		}

		protected void SetStateToggleButtons()
		{
		}

		protected virtual void ClearQuestTable()
		{
		}

		protected virtual void AddQuestsToTable()
		{
		}

		protected virtual void AddQuestGroupToTable(string group)
		{
		}

		protected virtual void AddQuestToTable(QuestInfo questInfo)
		{
		}

		protected virtual void SetQuestDetails(UnityUIQuestTemplate questControl, QuestInfo questInfo)
		{
		}

		public void NotifyContentChanged()
		{
		}

		public void ClickQuestFoldout(string questTitle)
		{
		}

		public void ClickQuestGroupFoldout(string group)
		{
		}

		protected void OnTrackButtonClicked(GameObject button)
		{
		}

		protected void OnAbandonButtonClicked(GameObject button)
		{
		}

		public override void ConfirmAbandonQuest(string title, Action confirmAbandonQuestHandler)
		{
		}

		protected void OpenAbandonPopup(string title)
		{
		}

		protected void CloseAbandonPopup()
		{
		}

		public void ClickConfirmAbandonQuestButton()
		{
		}

		public void ClickCancelAbandonQuestButton()
		{
		}
	}
}
