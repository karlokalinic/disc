using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IFriendInvitationSendListener : GalaxyTypeAwareListenerFriendInvitationSend
	{
		public delegate void SwigDelegateIFriendInvitationSendListener_0(IntPtr cPtr, IntPtr userID);

		public delegate void SwigDelegateIFriendInvitationSendListener_1(IntPtr cPtr, IntPtr userID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_USER_DOES_NOT_EXIST = 1,
			FAILURE_REASON_USER_ALREADY_INVITED = 2,
			FAILURE_REASON_USER_ALREADY_FRIEND = 3,
			FAILURE_REASON_CONNECTION_FAILURE = 4
		}

		private static Dictionary<IntPtr, IFriendInvitationSendListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIFriendInvitationSendListener_0 swigDelegate0;

		private SwigDelegateIFriendInvitationSendListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IFriendInvitationSendListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IFriendInvitationSendListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IFriendInvitationSendListener obj)
		{
			return default(HandleRef);
		}

		~IFriendInvitationSendListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnFriendInvitationSendSuccess(GalaxyID userID);

		public abstract void OnFriendInvitationSendFailure(GalaxyID userID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnFriendInvitationSendSuccess(IntPtr cPtr, IntPtr userID)
		{
		}

		private static void SwigDirectorOnFriendInvitationSendFailure(IntPtr cPtr, IntPtr userID, int failureReason)
		{
		}
	}
}
