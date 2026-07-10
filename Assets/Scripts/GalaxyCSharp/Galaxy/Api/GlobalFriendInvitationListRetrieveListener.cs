using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFriendInvitationListRetrieveListener : IFriendInvitationListRetrieveListener
	{
		private static Dictionary<IntPtr, GlobalFriendInvitationListRetrieveListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalFriendInvitationListRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFriendInvitationListRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFriendInvitationListRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFriendInvitationListRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
