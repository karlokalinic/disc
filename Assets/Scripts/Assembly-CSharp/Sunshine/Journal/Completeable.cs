using System;
using LocalizationCustomSystem;

namespace Sunshine.Journal
{
	public abstract class Completeable : IComparable
	{
		public TranslationString LocalizedNameTerm;

		public TranslationString LocalizedDescriptionTerm;

		public string Name { get; private set; }

		public string Description { get; private set; }

		public string ShowVariable { get; private set; }

		public string DoneVariable { get; private set; }

		public string CancelVariable { get; private set; }

		public bool IsSecret { get; private set; }

		public SunshineClockTime AquisitionTime { get; private set; }

		public SunshineClockTime FinishTime { get; private set; }

		public string LocalizedName => null;

		public string LocalizedNameUpper => null;

		public string LocalizedDescription => null;

		public virtual bool IsVisible { get; private set; }

		public bool IsDone { get; private set; }

		public virtual bool IsCanceled { get; private set; }

		public bool IsTimed { get; private set; }

		public Completeable(string name, string description, string showCondition, string doneCondition, string canceledCondition, bool isTimed)
		{
		}

		public virtual void Reveal()
		{
		}

		public virtual void MarkDone()
		{
		}

		public virtual bool CancelTask()
		{
			return false;
		}

		public void MarkUndoneAfterLoad()
		{
		}

		public void MarkDoneAfterLoad()
		{
		}

		public void MarkNotCancelledAfterLoad()
		{
		}

		public void MarkCancelledAfterLoad()
		{
		}

		public void MarkNotVisibleAfterLoad()
		{
		}

		public void SetTimesAfterLoad(SunshineClockTime aquisitionTime, SunshineClockTime resolutionTime)
		{
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
