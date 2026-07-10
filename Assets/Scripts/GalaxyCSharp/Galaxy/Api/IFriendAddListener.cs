using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IFriendAddListener : GalaxyTypeAwareListenerFriendAdd
	{
		public delegate void SwigDelegateIFriendAddListener_0(IntPtr cPtr, IntPtr userID, int invitationDirection);

		public enum InvitationDirection
		{
			INVITATION_DIRECTION_INCOMING = 0,
			INVITATION_DIRECTION_OUTGOING = 1
		}

		private static Dictionary<IntPtr, IFriendAddListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIFriendAddListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IFriendAddListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IFriendAddListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IFriendAddListener obj)
		{
			return default(HandleRef);
		}

		~IFriendAddListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnFriendAdded(GalaxyID userID, InvitationDirection invitationDirection);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnFriendAdded(IntPtr cPtr, IntPtr userID, int invitationDirection)
		{
		}
	}
}
