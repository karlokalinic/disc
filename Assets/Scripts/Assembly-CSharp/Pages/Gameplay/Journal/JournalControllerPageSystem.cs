using System.Collections.Generic;
using PagesSystem;
using Sunshine.Journal;
using TMPro;
using UnityEngine;

namespace Pages.Gameplay.Journal
{
	public class JournalControllerPageSystem : Singleton<JournalControllerPageSystem>
	{
		public static JournalControllerPageSystem INSTANCE;

		private bool tasksInitialized;

		public Color inBlockTitleTextColor;

		public Color outOfBlockTitleTextColor;

		public HashSet<string> WhiteChecksWithNotificationOnInit;

		private const int MAX_CHAR_IN_TITLE_LINE = 22;

		private const string NonBreakingSpace = "\ufffd";

		private const string WEEK_TITLE_PADDING = "\u00a0";

		private bool showDone;

		private bool showHidden;

		private TextMeshProUGUI unaquiredTaskListTitle;

		public bool TasksInitialized
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public Dictionary<string, WhiteCheck> ShownWhiteChecks { get; }

		public void OnInputKey()
		{
		}

		public void Start()
		{
		}

		public void ClearJournalDisplayObjects()
		{
		}

		public void Reinitialize()
		{
		}

		private bool GetIsTaskVisible(Completeable task)
		{
			return false;
		}

		private bool GetIsTaskDone(Completeable task)
		{
			return false;
		}

		public void InitInterface()
		{
		}

		public void DisplayTaskDetails(Completeable task)
		{
		}

		public void DisplayCheckCoords(PageSystemJournalWhiteCheckUI checkUI)
		{
		}

		public void OnWhiteCheckCached(WhiteCheck whiteCheck)
		{
		}

		public void OnSeenWhiteCheckCached(WhiteCheck whiteCheck)
		{
		}

		private bool ShouldWhiteCheckHaveNotificationOnInit(WhiteCheck whiteCheck)
		{
			return false;
		}

		public void OnSwitchedToView()
		{
		}

		private int UpdateTaskAndSubtasks(int index, JournalTask task)
		{
			return 0;
		}

		private JournalTaskUI UpdateJournalTaskUI(string name, SunshineClockTime aquisitionTime)
		{
			return null;
		}

		private JournalSubtaskUI UpdateJournalSubtaskUI(string name, SunshineClockTime aquisitionTime)
		{
			return null;
		}

		public void UpdateShownWhiteChecks()
		{
		}

		public bool IsCheckReopened(WhiteCheck whiteCheck)
		{
			return false;
		}

		private void PositionObject(Transform transform, int index)
		{
		}

		public static void ImportFromArticy()
		{
		}

		public void NotifyTaskDone()
		{
		}

		public void NotifyTaskRevealed()
		{
		}

		public void NotifySubtaskUpdated()
		{
		}

		private bool CheckIsInDictionary(WhiteCheck whiteCheck)
		{
			return false;
		}
	}
}
