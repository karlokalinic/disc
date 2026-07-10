using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalGameInvitationReceivedListener : IGameInvitationReceivedListener
	{
		private static Dictionary<IntPtr, GlobalGameInvitationReceivedListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalGameInvitationReceivedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalGameInvitationReceivedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalGameInvitationReceivedListener obj)
		{
			return default(HandleRef);
		}

		~GlobalGameInvitationReceivedListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
