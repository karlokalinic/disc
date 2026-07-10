using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IChatRoomMessagesRetrieveListener : GalaxyTypeAwareListenerChatRoomMessagesRetrieve
	{
		public delegate void SwigDelegateIChatRoomMessagesRetrieveListener_0(IntPtr cPtr, ulong chatRoomID, uint messageCount, uint longestMessageLenght);

		public delegate void SwigDelegateIChatRoomMessagesRetrieveListener_1(IntPtr cPtr, ulong chatRoomID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_FORBIDDEN = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, IChatRoomMessagesRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIChatRoomMessagesRetrieveListener_0 swigDelegate0;

		private SwigDelegateIChatRoomMessagesRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IChatRoomMessagesRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IChatRoomMessagesRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IChatRoomMessagesRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~IChatRoomMessagesRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnChatRoomMessagesRetrieveSuccess(ulong chatRoomID, uint messageCount, uint longestMessageLenght);

		public abstract void OnChatRoomMessagesRetrieveFailure(ulong chatRoomID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnChatRoomMessagesRetrieveSuccess(IntPtr cPtr, ulong chatRoomID, uint messageCount, uint longestMessageLenght)
		{
		}

		private static void SwigDirectorOnChatRoomMessagesRetrieveFailure(IntPtr cPtr, ulong chatRoomID, int failureReason)
		{
		}
	}
}
