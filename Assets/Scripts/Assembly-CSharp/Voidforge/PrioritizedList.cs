using System;
using System.Collections.Generic;

namespace Voidforge
{
	public class PrioritizedList<T> : IDisposable
	{
		protected bool _firstComeFirstServed;

		protected int _lockCount;

		protected int _removedCount;

		protected float _compactTreshold;

		protected List<int?> _priorities;

		protected List<T> _values;

		protected List<T> _queuedValues;

		protected List<int?> _queuedPriorities;

		protected Timer _timer;

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public float CompactInterval
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int currentPriority { get; protected set; }

		public int Capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool isLocked => false;

		public PrioritizedList(bool firstComeFirstServed = true)
		{
		}

		public void Add(T value, int priority = 0)
		{
		}

		public void Compact()
		{
		}

		public void Dispose()
		{
		}

		public void ForEach(Action<T> Callback)
		{
		}

		public int GetPriority(int index)
		{
			return 0;
		}

		public T Peek()
		{
			return default(T);
		}

		public bool Remove(T value)
		{
			return false;
		}

		public int RemoveAll(T value)
		{
			return 0;
		}

		public void TrimExcess()
		{
		}

		protected int idx(int order)
		{
			return 0;
		}

		protected void Insert(T value, int priority)
		{
		}

		public bool IsAlreadyQueued(T value)
		{
			return false;
		}

		protected void Lock()
		{
		}

		protected void ProcessQueue()
		{
		}

		protected void Unlock(bool processQueue = true)
		{
		}

		public void ForceUnlock()
		{
		}
	}
}
