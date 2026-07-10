using System.Collections;
using System.Threading;

namespace UnityThread
{
	public class ThreadedJob
	{
		private bool m_IsDone;

		private object m_Handle;

		private Thread m_Thread;

		public bool IsDone
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Start()
		{
		}

		public virtual void Abort()
		{
		}

		protected virtual void ThreadFunction()
		{
		}

		protected virtual void OnFinished()
		{
		}

		public virtual bool Update()
		{
			return false;
		}

		public IEnumerator WaitFor()
		{
			return null;
		}

		private void Run()
		{
		}
	}
}
