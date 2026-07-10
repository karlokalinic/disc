using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyMemberStateListener : GalaxyTypeAwareListenerLobbyMemberState
	{
		public delegate void SwigDelegateILobbyMemberStateListener_0(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID, int memberStateChange);

		private static Dictionary<IntPtr, ILobbyMemberStateListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyMemberStateListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyMemberStateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyMemberStateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyMemberStateListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyMemberStateListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyMemberStateChanged(GalaxyID lobbyID, GalaxyID memberID, LobbyMemberStateChange memberStateChange);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyMemberStateChanged(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID, int memberStateChange)
		{
		}
	}
}
