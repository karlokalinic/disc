using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IChatRoomWithUserRetrieveListener : GalaxyTypeAwareListenerChatRoomWithUserRetrieve
	{
		public delegate void SwigDelegateIChatRoomWithUserRetrieveListener_0(IntPtr cPtr, IntPtr userID, ulong chatRoomID);

		public delegate void SwigDelegateIChatRoomWithUserRetrieveListener_1(IntPtr cPtr, IntPtr userID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_FORBIDDEN = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, IChatRoomWithUserRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIChatRoomWithUserRetrieveListener_0 swigDelegate0;

		private SwigDelegateIChatRoomWithUserRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IChatRoomWithUserRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IChatRoomWithUserRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IChatRoomWithUserRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~IChatRoomWithUserRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnChatRoomWithUserRetrieveSuccess(GalaxyID userID, ulong chatRoomID);

		public abstract void OnChatRoomWithUserRetrieveFailure(GalaxyID userID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnChatRoomWithUserRetrieveSuccess(IntPtr cPtr, IntPtr userID, ulong chatRoomID)
		{
		}

		private static void SwigDirectorOnChatRoomWithUserRetrieveFailure(IntPtr cPtr, IntPtr userID, int failureReason)
		{
		}
	}
}
