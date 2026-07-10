using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFriendInvitationRespondToListener : IFriendInvitationRespondToListener
	{
		private static Dictionary<IntPtr, GlobalFriendInvitationRespondToListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalFriendInvitationRespondToListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFriendInvitationRespondToListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFriendInvitationRespondToListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFriendInvitationRespondToListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
