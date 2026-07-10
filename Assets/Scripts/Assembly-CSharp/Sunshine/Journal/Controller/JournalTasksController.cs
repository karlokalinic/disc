using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunshine.Journal.Controller
{
	public class JournalTasksController : MonoBehaviour
	{
		public JournalTaskUI taskTemplate;

		public RectTransform taskListContainer;

		public VerticalStepScrollView tasksVerticalStep;

		public static bool showDone;

		private JournalWeekdaysController weekdaysController;

		[SerializeField]
		private LayoutDisabler layoutDisabler;

		private readonly Dictionary<string, JournalTask> allTasks;

		private readonly Dictionary<JournalTask, JournalTaskUI> tasksUI;

		public void Init(bool reinitializeIfExisting = false)
		{
		}

		private void Reinitialize()
		{
		}

		public void DrawTasks()
		{
		}

		public void RecreateWeekdays()
		{
		}

		private JournalTaskUI InstantiateTaskUI(Completeable task)
		{
			return null;
		}

		private void UpdateJournalTaskUI(JournalTask task, SunshineClockTime acquisitionTime)
		{
		}

		public static bool GetIsTaskVisible(Completeable task)
		{
			return false;
		}

		private static bool GetIsTaskDone(Completeable task)
		{
			return false;
		}

		public void SelectLastTask(bool activeTab)
		{
		}

		private void SelectLastActiveTask()
		{
		}

		private void SelectLastDoneTask()
		{
		}

		public void SelectTask(string taskName)
		{
		}

		public void SetDoneTask(string taskName)
		{
		}

		private IEnumerator SelectTaskWaitForInitialise(JournalTask task)
		{
			return null;
		}

		private IEnumerator SetDoneTaskWaitForInitialise(JournalTask task)
		{
			return null;
		}
	}
}
