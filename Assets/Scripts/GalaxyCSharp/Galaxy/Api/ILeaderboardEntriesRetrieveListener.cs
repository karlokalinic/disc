using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILeaderboardEntriesRetrieveListener : GalaxyTypeAwareListenerLeaderboardEntriesRetrieve
	{
		public delegate void SwigDelegateILeaderboardEntriesRetrieveListener_0(IntPtr cPtr, string name, uint entryCount);

		public delegate void SwigDelegateILeaderboardEntriesRetrieveListener_1(IntPtr cPtr, string name, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_NOT_FOUND = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, ILeaderboardEntriesRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILeaderboardEntriesRetrieveListener_0 swigDelegate0;

		private SwigDelegateILeaderboardEntriesRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ILeaderboardEntriesRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILeaderboardEntriesRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILeaderboardEntriesRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~ILeaderboardEntriesRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLeaderboardEntriesRetrieveSuccess(string name, uint entryCount);

		public abstract void OnLeaderboardEntriesRetrieveFailure(string name, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLeaderboardEntriesRetrieveSuccess(IntPtr cPtr, string name, uint entryCount)
		{
		}

		private static void SwigDirectorOnLeaderboardEntriesRetrieveFailure(IntPtr cPtr, string name, int failureReason)
		{
		}
	}
}
