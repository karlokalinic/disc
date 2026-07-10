using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILeaderboardsRetrieveListener : GalaxyTypeAwareListenerLeaderboardsRetrieve
	{
		public delegate void SwigDelegateILeaderboardsRetrieveListener_0(IntPtr cPtr);

		public delegate void SwigDelegateILeaderboardsRetrieveListener_1(IntPtr cPtr, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, ILeaderboardsRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILeaderboardsRetrieveListener_0 swigDelegate0;

		private SwigDelegateILeaderboardsRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ILeaderboardsRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILeaderboardsRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILeaderboardsRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~ILeaderboardsRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLeaderboardsRetrieveSuccess();

		public abstract void OnLeaderboardsRetrieveFailure(FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLeaderboardsRetrieveSuccess(IntPtr cPtr)
		{
		}

		private static void SwigDirectorOnLeaderboardsRetrieveFailure(IntPtr cPtr, int failureReason)
		{
		}
	}
}
