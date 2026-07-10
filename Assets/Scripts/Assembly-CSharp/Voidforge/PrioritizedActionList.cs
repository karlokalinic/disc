using System;

namespace Voidforge
{
	public class PrioritizedActionList : PrioritizedList<Action>
	{
		public void Invoke()
		{
		}

		public PrioritizedActionList(bool firstComeFirstServed = true)
			: base(false)
		{
		}

		public void PrintListContent()
		{
		}
	}
	public class PrioritizedActionList<T> : PrioritizedList<Action<T>>
	{
		public void Invoke(T value)
		{
		}

		public PrioritizedActionList(bool firstComeFirstServed = true)
			: base(false)
		{
		}
	}
}
