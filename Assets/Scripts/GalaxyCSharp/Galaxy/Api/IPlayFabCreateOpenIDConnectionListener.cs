using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IPlayFabCreateOpenIDConnectionListener : IDisposable
	{
		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IPlayFabCreateOpenIDConnectionListener> listeners;

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IPlayFabCreateOpenIDConnectionListener(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IPlayFabCreateOpenIDConnectionListener obj)
		{
			return default(HandleRef);
		}

		~IPlayFabCreateOpenIDConnectionListener()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void OnPlayFabCreateOpenIDConnectionSuccess(bool connectionAlreadyExists)
		{
		}

		public virtual void OnPlayFabCreateOpenIDConnectionFailure(FailureReason failureReason)
		{
		}
	}
}
