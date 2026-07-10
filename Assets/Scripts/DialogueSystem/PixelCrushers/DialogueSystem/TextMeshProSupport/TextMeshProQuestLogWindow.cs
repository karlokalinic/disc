using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProQuestLogWindow : QuestLogWindow
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public Graphic mainPanel;

		public Button activeQuestsButton;

		public Button completedQuestsButton;

		public Graphic questTable;

		public TextMeshProQuestTemplate questTemplate;

		public Graphic abandonPopup;

		public TextMeshProUGUI abandonQuestTitle;

		public bool autoFocus;

		public UnityEvent onContentChanged;

		public AnimationTransitions animationTransitions;

		private Action confirmAbandonQuestHandler;

		private Animator animator;

		public override void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public void Update()
		{
		}

		public override void OpenWindow(Action openedWindowHandler)
		{
		}

		public override void CloseWindow(Action closedWindowHandler)
		{
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}

		private IEnumerator OpenAfterAnimation(Action openedWindowHandler)
		{
			return null;
		}

		private IEnumerator CloseAfterAnimation(Action closedWindowHandler)
		{
			return null;
		}

		public override void OnQuestListUpdated()
		{
		}

		private void SetStateButtonListeners()
		{
		}

		private void SetStateToggleButtons()
		{
		}

		private void ClearQuestTable()
		{
		}

		private void AddQuestsToTable()
		{
		}

		public void NotifyContentChanged()
		{
		}

		private void AddQuestToTable(QuestInfo questInfo, int questIndex)
		{
		}

		public void ClickQuestFoldout(string questTitle)
		{
		}

		private void OnTrackButtonClicked(GameObject button)
		{
		}

		private void OnAbandonButtonClicked(GameObject button)
		{
		}

		public override void ConfirmAbandonQuest(string title, Action confirmAbandonQuestHandler)
		{
		}

		private void OpenAbandonPopup(string title)
		{
		}

		private void CloseAbandonPopup()
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
