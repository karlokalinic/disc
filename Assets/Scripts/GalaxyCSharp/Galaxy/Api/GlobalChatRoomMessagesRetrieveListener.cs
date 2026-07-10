using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalChatRoomMessagesRetrieveListener : IChatRoomMessagesRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalChatRoomMessagesRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalChatRoomMessagesRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalChatRoomMessagesRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalChatRoomMessagesRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
