using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalChatRoomWithUserRetrieveListener : IChatRoomWithUserRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalChatRoomWithUserRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalChatRoomWithUserRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalChatRoomWithUserRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalChatRoomWithUserRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
