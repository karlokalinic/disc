using System.Collections.Generic;
using Sunshine.Metric;

namespace Sunshine.Journal
{
	public class JournalTask : Completeable
	{
		public List<JournalSubtask> AvailableSubtasks;

		public List<JournalSubtask> GainedSubtasks;

		public int reward;

		private bool _isNew;

		private RewardType rewardType;

		public RewardType RewardType => default(RewardType);

		public bool IsNew
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public JournalTask(string name, string description, string showCondition, string doneCondition, string cancelCondition, int reward, bool isTimed, RewardType rewardType)
			: base(null, null, null, null, null, isTimed: false)
		{
		}

		public override void Reveal()
		{
		}

		public override void MarkDone()
		{
		}

		public override bool CancelTask()
		{
			return false;
		}

		private void CancelSubtasks()
		{
		}

		public JournalSubtask AddSubtask(string subtaskNumber, string id, string name, string description, string showCondition, string doneCondition, string cancelCondition, bool isTimed)
		{
			return null;
		}

		public void GainSubtask(JournalSubtask subtask)
		{
		}
	}
}
