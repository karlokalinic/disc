using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IFriendInvitationRespondToListener : GalaxyTypeAwareListenerFriendInvitationRespondTo
	{
		public delegate void SwigDelegateIFriendInvitationRespondToListener_0(IntPtr cPtr, IntPtr userID, bool accept);

		public delegate void SwigDelegateIFriendInvitationRespondToListener_1(IntPtr cPtr, IntPtr userID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_USER_DOES_NOT_EXIST = 1,
			FAILURE_REASON_FRIEND_INVITATION_DOES_NOT_EXIST = 2,
			FAILURE_REASON_USER_ALREADY_FRIEND = 3,
			FAILURE_REASON_CONNECTION_FAILURE = 4
		}

		private static Dictionary<IntPtr, IFriendInvitationRespondToListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIFriendInvitationRespondToListener_0 swigDelegate0;

		private SwigDelegateIFriendInvitationRespondToListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IFriendInvitationRespondToListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IFriendInvitationRespondToListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IFriendInvitationRespondToListener obj)
		{
			return default(HandleRef);
		}

		~IFriendInvitationRespondToListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnFriendInvitationRespondToSuccess(GalaxyID userID, bool accept);

		public abstract void OnFriendInvitationRespondToFailure(GalaxyID userID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnFriendInvitationRespondToSuccess(IntPtr cPtr, IntPtr userID, bool accept)
		{
		}

		private static void SwigDirectorOnFriendInvitationRespondToFailure(IntPtr cPtr, IntPtr userID, int failureReason)
		{
		}
	}
}
