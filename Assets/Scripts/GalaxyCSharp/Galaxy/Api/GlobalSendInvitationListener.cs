using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalSendInvitationListener : ISendInvitationListener
	{
		private static Dictionary<IntPtr, GlobalSendInvitationListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalSendInvitationListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalSendInvitationListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalSendInvitationListener obj)
		{
			return default(HandleRef);
		}

		~GlobalSendInvitationListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
