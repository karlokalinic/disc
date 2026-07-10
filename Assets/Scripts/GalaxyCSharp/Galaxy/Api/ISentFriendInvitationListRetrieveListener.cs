using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ISentFriendInvitationListRetrieveListener : GalaxyTypeAwareListenerSentFriendInvitationListRetrieve
	{
		public delegate void SwigDelegateISentFriendInvitationListRetrieveListener_0(IntPtr cPtr);

		public delegate void SwigDelegateISentFriendInvitationListRetrieveListener_1(IntPtr cPtr, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, ISentFriendInvitationListRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateISentFriendInvitationListRetrieveListener_0 swigDelegate0;

		private SwigDelegateISentFriendInvitationListRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ISentFriendInvitationListRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ISentFriendInvitationListRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ISentFriendInvitationListRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~ISentFriendInvitationListRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnSentFriendInvitationListRetrieveSuccess();

		public abstract void OnSentFriendInvitationListRetrieveFailure(FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnSentFriendInvitationListRetrieveSuccess(IntPtr cPtr)
		{
		}

		private static void SwigDirectorOnSentFriendInvitationListRetrieveFailure(IntPtr cPtr, int failureReason)
		{
		}
	}
}
