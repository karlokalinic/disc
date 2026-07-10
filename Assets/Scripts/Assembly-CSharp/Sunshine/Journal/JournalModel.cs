using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine.Events;

namespace Sunshine.Journal
{
	public class JournalModel
	{
		private const int XPAMOUNT = 10;

		public static JournalModel SINGLETON;

		private int _freshCount;

		private Dictionary<string, Completeable> condition2Completeable;

		public HashSet<JournalTask> AllAvailableTasks;

		public HashSet<JournalTask> GainedTasks;

		public UnityEvent OnClearGainedTasksAndResetStates;

		public int FreshCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private JournalModel()
		{
		}

		public void GainTask(string varName)
		{
		}

		public bool IsTaskFinished(string varName)
		{
			return false;
		}

		public void FinishTask(string varName)
		{
		}

		public void CancelTask(string varName)
		{
		}

		public bool IsTaskActive(string varName)
		{
			return false;
		}

		public void ClearGainedTasksAndResetStates()
		{
		}

		public JournalTask AddTask(string id, string name, string description, string showCondition, string doneCondition, string cancelCondition, int reward, bool isTimed, RewardType rewardType)
		{
			return null;
		}

		public void AddTaskToCondition2NameMap(Completeable task)
		{
		}

		private void AddToDictionary(string key, Completeable value)
		{
		}

		public Completeable GetByConditionVariable(string showCondition)
		{
			return null;
		}
	}
}
