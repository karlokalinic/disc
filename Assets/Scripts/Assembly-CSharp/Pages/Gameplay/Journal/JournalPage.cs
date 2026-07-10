using System.Collections.Generic;
using DG.Tweening;
using DiscoPages.Elements.Common;
using DiscoPages.Elements.Journal;
using PagesSystem;
using Sunshine.Journal;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.Journal
{
	public class JournalPage : SubPage
	{
		[SerializeField]
		private PageSystemJournalTasksScroll tasksScroll;

		[SerializeField]
		private Button badgeNavigateButton;

		[SerializeField]
		private Button mapNavigateButton;

		[SerializeField]
		private JournalTaskUI taskPrefab;

		[SerializeField]
		private TextMeshProUGUI weekDayTextPrefab;

		[SerializeField]
		private RectTransform tasksContainer;

		[SerializeField]
		private Button[] activeDoneTabButtons;

		[SerializeField]
		private TabSwitchAnimationController tabSwitchIndicator;

		private bool showHidden;

		private bool showDone;

		private Dictionary<string, JournalTaskUI> taskUIItems;

		private JournalNavigationParameters journalNavigationParameters;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		private void OnMapPageClicked()
		{
		}

		private void DrawTasks(HashSet<JournalTask> gainedTasks)
		{
		}

		private JournalTaskUI InstantiateJournalTaskUI(Completeable task, string name, int indent)
		{
			return null;
		}

		private int UpdateTaskAndSubtasks(int index, JournalTask task)
		{
			return 0;
		}

		private JournalTaskUI UpdateJournalTaskUI(string name, SunshineClockTime aquisitionTime)
		{
			return null;
		}

		private bool GetIsTaskVisible(Completeable task)
		{
			return false;
		}

		private bool GetIsTaskDone(Completeable task)
		{
			return false;
		}

		private void PositionObject(Transform transform, int index)
		{
		}

		private TextMeshProUGUI GetOrCreateWeekday(string dayOfWeek)
		{
			return null;
		}

		public override Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public override Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}

		private void AddTaskButtonEvent(Button button)
		{
		}

		private void ToggleActiveDone()
		{
		}

		private void ShowActiveTasks()
		{
		}

		private void ShowDoneTasks()
		{
		}

		private void UpdateTasksVisibility()
		{
		}

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}
	}
}
