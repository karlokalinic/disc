namespace Sunshine.Journal
{
	public class JournalSubtask : Completeable
	{
		public JournalTask parent;

		public override bool IsVisible => false;

		public JournalSubtask(string name, string description, string showCondition, string doneCondition, string cancelCondition, bool isTimed)
			: base(null, null, null, null, null, isTimed: false)
		{
		}

		public bool IsVisibleSelf()
		{
			return false;
		}

		public override void Reveal()
		{
		}

		public override void MarkDone()
		{
		}
	}
}
