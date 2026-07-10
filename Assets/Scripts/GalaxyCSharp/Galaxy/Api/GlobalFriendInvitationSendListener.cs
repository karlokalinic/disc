using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFriendInvitationSendListener : IFriendInvitationSendListener
	{
		private static Dictionary<IntPtr, GlobalFriendInvitationSendListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalFriendInvitationSendListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFriendInvitationSendListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFriendInvitationSendListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFriendInvitationSendListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
