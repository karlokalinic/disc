using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class QuestLogWindow : MonoBehaviour
	{
		public enum QuestHeadingSource
		{
			Name = 0,
			Description = 1
		}

		[Serializable]
		public class QuestInfo
		{
			public string Group { get; set; }

			public string Title { get; set; }

			public FormattedText Heading { get; set; }

			public FormattedText Description { get; set; }

			public FormattedText[] Entries { get; set; }

			public QuestState[] EntryStates { get; set; }

			public bool Trackable { get; set; }

			public bool Track { get; set; }

			public bool Abandonable { get; set; }

			public QuestInfo(string group, string title, FormattedText heading, FormattedText description, FormattedText[] entries, QuestState[] entryStates, bool trackable, bool track, bool abandonable)
			{
			}

			public QuestInfo(string title, FormattedText heading, FormattedText description, FormattedText[] entries, QuestState[] entryStates, bool trackable, bool track, bool abandonable)
			{
			}
		}

		public TextTable textTable;

		public string noActiveQuestsText;

		public string noCompletedQuestsText;

		public bool checkVisibleField;

		public QuestHeadingSource questHeadingSource;

		[QuestState]
		public QuestState abandonQuestState;

		public bool pauseWhileOpen;

		public bool unlockCursorWhileOpen;

		public bool useGroups;

		public bool trackOneQuestAtATime;

		protected QuestState currentQuestStateMask;

		private float previousTimeScale;

		private bool wasCursorActive;

		public bool isOpen { get; protected set; }

		public QuestInfo[] quests { get; protected set; }

		public string[] groups { get; protected set; }

		public string selectedQuest { get; protected set; }

		public string noQuestsMessage { get; protected set; }

		public bool isShowingActiveQuests => false;

		public bool IsOpen
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public QuestInfo[] Quests
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string[] Groups
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string SelectedQuest
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string NoQuestsMessage
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool IsShowingActiveQuests => false;

		public virtual void OpenWindow(Action openedWindowHandler)
		{
		}

		public virtual void CloseWindow(Action closedWindowHandler)
		{
		}

		public virtual void OnQuestListUpdated()
		{
		}

		public virtual void ConfirmAbandonQuest(string title, Action confirmedAbandonQuestHandler)
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Open()
		{
		}

		protected virtual void OnOpenedWindow()
		{
		}

		public virtual void Close()
		{
		}

		protected virtual void OnClosedWindow()
		{
		}

		protected virtual void PauseGameplay()
		{
		}

		protected virtual void ResumeGameplay()
		{
		}

		public virtual bool IsQuestVisible(string questTitle)
		{
			return false;
		}

		protected virtual void ShowQuests(QuestState questStateMask)
		{
		}

		protected virtual QuestInfo GetQuestInfo(string group, string title)
		{
			return null;
		}

		protected virtual string GetNoQuestsMessage(QuestState questStateMask)
		{
			return null;
		}

		public virtual string GetLocalizedText(string fieldName)
		{
			return null;
		}

		public virtual bool IsSelectedQuest(QuestInfo questInfo)
		{
			return false;
		}

		public void ClickClose(object data)
		{
		}

		public virtual void ClickShowActiveQuests(object data)
		{
		}

		public virtual void ClickShowCompletedQuests(object data)
		{
		}

		public virtual void ClickQuest(object data)
		{
		}

		public virtual void ClickAbandonQuest(object data)
		{
		}

		protected virtual void OnConfirmAbandonQuest()
		{
		}

		public virtual void ClickTrackQuest(object data)
		{
		}

		private bool IsString(object data)
		{
			return false;
		}

		public virtual void ClickShowActiveQuestsButton()
		{
		}

		public void ClickShowCompletedQuestsButton()
		{
		}

		public void ClickCloseButton()
		{
		}

		public void ClickAbandonQuestButton()
		{
		}

		public void ClickTrackQuestButton()
		{
		}

		public void UpdateTracker()
		{
		}
	}
}
