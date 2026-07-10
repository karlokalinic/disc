using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILeaderboardScoreUpdateListener : GalaxyTypeAwareListenerLeaderboardScoreUpdate
	{
		public delegate void SwigDelegateILeaderboardScoreUpdateListener_0(IntPtr cPtr, string name, int score, uint oldRank, uint newRank);

		public delegate void SwigDelegateILeaderboardScoreUpdateListener_1(IntPtr cPtr, string name, int score, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_NO_IMPROVEMENT = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, ILeaderboardScoreUpdateListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILeaderboardScoreUpdateListener_0 swigDelegate0;

		private SwigDelegateILeaderboardScoreUpdateListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ILeaderboardScoreUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILeaderboardScoreUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILeaderboardScoreUpdateListener obj)
		{
			return default(HandleRef);
		}

		~ILeaderboardScoreUpdateListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLeaderboardScoreUpdateSuccess(string name, int score, uint oldRank, uint newRank);

		public abstract void OnLeaderboardScoreUpdateFailure(string name, int score, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLeaderboardScoreUpdateSuccess(IntPtr cPtr, string name, int score, uint oldRank, uint newRank)
		{
		}

		private static void SwigDirectorOnLeaderboardScoreUpdateFailure(IntPtr cPtr, string name, int score, int failureReason)
		{
		}
	}
}
