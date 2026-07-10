using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalChatRoomMessagesListener : IChatRoomMessagesListener
	{
		private HandleRef swigCPtr;

		internal GlobalChatRoomMessagesListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalChatRoomMessagesListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalChatRoomMessagesListener obj)
		{
			return default(HandleRef);
		}

		~GlobalChatRoomMessagesListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
