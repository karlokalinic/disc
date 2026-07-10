using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IFriendInvitationListRetrieveListener : GalaxyTypeAwareListenerFriendInvitationListRetrieve
	{
		public delegate void SwigDelegateIFriendInvitationListRetrieveListener_0(IntPtr cPtr);

		public delegate void SwigDelegateIFriendInvitationListRetrieveListener_1(IntPtr cPtr, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IFriendInvitationListRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIFriendInvitationListRetrieveListener_0 swigDelegate0;

		private SwigDelegateIFriendInvitationListRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IFriendInvitationListRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IFriendInvitationListRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IFriendInvitationListRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~IFriendInvitationListRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnFriendInvitationListRetrieveSuccess();

		public abstract void OnFriendInvitationListRetrieveFailure(FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnFriendInvitationListRetrieveSuccess(IntPtr cPtr)
		{
		}

		private static void SwigDirectorOnFriendInvitationListRetrieveFailure(IntPtr cPtr, int failureReason)
		{
		}
	}
}
