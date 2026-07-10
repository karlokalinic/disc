using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFriendInvitationListener : IFriendInvitationListener
	{
		private static Dictionary<IntPtr, GlobalFriendInvitationListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalFriendInvitationListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFriendInvitationListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFriendInvitationListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFriendInvitationListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
