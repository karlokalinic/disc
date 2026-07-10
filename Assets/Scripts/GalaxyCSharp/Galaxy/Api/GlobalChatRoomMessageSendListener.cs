using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalChatRoomMessageSendListener : IChatRoomMessageSendListener
	{
		private HandleRef swigCPtr;

		internal GlobalChatRoomMessageSendListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalChatRoomMessageSendListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalChatRoomMessageSendListener obj)
		{
			return default(HandleRef);
		}

		~GlobalChatRoomMessageSendListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
