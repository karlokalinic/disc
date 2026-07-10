using System;
using System.Collections.Generic;

namespace Voidforge
{
	public class AgentCollection : IDisposable
	{
		protected HashSet<Agent> _agents;

		protected Timer _timer;

		public float cleanupInterval
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool Add(Agent item)
		{
			return false;
		}

		public void Dispose()
		{
		}

		public void ForEach(Action<Agent> Action)
		{
		}
	}
}
