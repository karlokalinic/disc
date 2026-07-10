using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IChatRoomMessagesListener : GalaxyTypeAwareListenerChatRoomMessages
	{
		public delegate void SwigDelegateIChatRoomMessagesListener_0(IntPtr cPtr, ulong chatRoomID, uint messageCount, uint longestMessageLenght);

		private static Dictionary<IntPtr, IChatRoomMessagesListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIChatRoomMessagesListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IChatRoomMessagesListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IChatRoomMessagesListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IChatRoomMessagesListener obj)
		{
			return default(HandleRef);
		}

		~IChatRoomMessagesListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnChatRoomMessagesReceived(ulong chatRoomID, uint messageCount, uint longestMessageLenght);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnChatRoomMessagesReceived(IntPtr cPtr, ulong chatRoomID, uint messageCount, uint longestMessageLenght)
		{
		}
	}
}
