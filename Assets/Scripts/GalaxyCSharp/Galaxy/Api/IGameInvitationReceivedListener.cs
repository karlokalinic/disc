using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IGameInvitationReceivedListener : GalaxyTypeAwareListenerGameInvitationReceived
	{
		public delegate void SwigDelegateIGameInvitationReceivedListener_0(IntPtr cPtr, IntPtr userID, string connectionString);

		private static Dictionary<IntPtr, IGameInvitationReceivedListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIGameInvitationReceivedListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IGameInvitationReceivedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IGameInvitationReceivedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IGameInvitationReceivedListener obj)
		{
			return default(HandleRef);
		}

		~IGameInvitationReceivedListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnGameInvitationReceived(GalaxyID userID, string connectionString);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnGameInvitationReceived(IntPtr cPtr, IntPtr userID, string connectionString)
		{
		}
	}
}
