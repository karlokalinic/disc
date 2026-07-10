using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalSentFriendInvitationListRetrieveListener : ISentFriendInvitationListRetrieveListener
	{
		private static Dictionary<IntPtr, GlobalSentFriendInvitationListRetrieveListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalSentFriendInvitationListRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalSentFriendInvitationListRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalSentFriendInvitationListRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalSentFriendInvitationListRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
