using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IChatRoomMessageSendListener : GalaxyTypeAwareListenerChatRoomMessageSend
	{
		public delegate void SwigDelegateIChatRoomMessageSendListener_0(IntPtr cPtr, ulong chatRoomID, uint sentMessageIndex, ulong messageID, uint sendTime);

		public delegate void SwigDelegateIChatRoomMessageSendListener_1(IntPtr cPtr, ulong chatRoomID, uint sentMessageIndex, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_FORBIDDEN = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, IChatRoomMessageSendListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIChatRoomMessageSendListener_0 swigDelegate0;

		private SwigDelegateIChatRoomMessageSendListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IChatRoomMessageSendListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IChatRoomMessageSendListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IChatRoomMessageSendListener obj)
		{
			return default(HandleRef);
		}

		~IChatRoomMessageSendListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnChatRoomMessageSendSuccess(ulong chatRoomID, uint sentMessageIndex, ulong messageID, uint sendTime);

		public abstract void OnChatRoomMessageSendFailure(ulong chatRoomID, uint sentMessageIndex, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnChatRoomMessageSendSuccess(IntPtr cPtr, ulong chatRoomID, uint sentMessageIndex, ulong messageID, uint sendTime)
		{
		}

		private static void SwigDirectorOnChatRoomMessageSendFailure(IntPtr cPtr, ulong chatRoomID, uint sentMessageIndex, int failureReason)
		{
		}
	}
}
