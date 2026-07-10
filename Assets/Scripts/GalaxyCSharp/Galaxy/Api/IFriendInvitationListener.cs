using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IFriendInvitationListener : GalaxyTypeAwareListenerFriendInvitation
	{
		public delegate void SwigDelegateIFriendInvitationListener_0(IntPtr cPtr, IntPtr userID, uint sendTime);

		private static Dictionary<IntPtr, IFriendInvitationListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIFriendInvitationListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IFriendInvitationListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IFriendInvitationListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IFriendInvitationListener obj)
		{
			return default(HandleRef);
		}

		~IFriendInvitationListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnFriendInvitationReceived(GalaxyID userID, uint sendTime);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnFriendInvitationReceived(IntPtr cPtr, IntPtr userID, uint sendTime)
		{
		}
	}
}
