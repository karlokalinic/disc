using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILeaderboardRetrieveListener : GalaxyTypeAwareListenerLeaderboardRetrieve
	{
		public delegate void SwigDelegateILeaderboardRetrieveListener_0(IntPtr cPtr, string name);

		public delegate void SwigDelegateILeaderboardRetrieveListener_1(IntPtr cPtr, string name, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, ILeaderboardRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILeaderboardRetrieveListener_0 swigDelegate0;

		private SwigDelegateILeaderboardRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ILeaderboardRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILeaderboardRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILeaderboardRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~ILeaderboardRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLeaderboardRetrieveSuccess(string name);

		public abstract void OnLeaderboardRetrieveFailure(string name, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLeaderboardRetrieveSuccess(IntPtr cPtr, string name)
		{
		}

		private static void SwigDirectorOnLeaderboardRetrieveFailure(IntPtr cPtr, string name, int failureReason)
		{
		}
	}
}
