using System;
using UnityEngine;

namespace Voidforge
{
	public class Agent : IDisposable
	{
		protected bool _isFinished;

		protected Behaviour parent;

		public bool isFinished => false;

		public Agent(Behaviour parent)
		{
		}

		public virtual void Dispose()
		{
		}
	}
}
