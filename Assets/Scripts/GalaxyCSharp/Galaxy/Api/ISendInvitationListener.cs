using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ISendInvitationListener : GalaxyTypeAwareListenerSendInvitation
	{
		public delegate void SwigDelegateISendInvitationListener_0(IntPtr cPtr, IntPtr userID, string connectionString);

		public delegate void SwigDelegateISendInvitationListener_1(IntPtr cPtr, IntPtr userID, string connectionString, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_USER_DOES_NOT_EXIST = 1,
			FAILURE_REASON_RECEIVER_DOES_NOT_ALLOW_INVITING = 2,
			FAILURE_REASON_SENDER_DOES_NOT_ALLOW_INVITING = 3,
			FAILURE_REASON_RECEIVER_BLOCKED = 4,
			FAILURE_REASON_SENDER_BLOCKED = 5,
			FAILURE_REASON_CONNECTION_FAILURE = 6
		}

		private static Dictionary<IntPtr, ISendInvitationListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateISendInvitationListener_0 swigDelegate0;

		private SwigDelegateISendInvitationListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ISendInvitationListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ISendInvitationListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ISendInvitationListener obj)
		{
			return default(HandleRef);
		}

		~ISendInvitationListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnInvitationSendSuccess(GalaxyID userID, string connectionString);

		public abstract void OnInvitationSendFailure(GalaxyID userID, string connectionString, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnInvitationSendSuccess(IntPtr cPtr, IntPtr userID, string connectionString)
		{
		}

		private static void SwigDirectorOnInvitationSendFailure(IntPtr cPtr, IntPtr userID, string connectionString, int failureReason)
		{
		}
	}
}
