using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyLeftListener : GalaxyTypeAwareListenerLobbyLeft
	{
		public delegate void SwigDelegateILobbyLeftListener_0(IntPtr cPtr, IntPtr lobbyID, int leaveReason);

		public enum LobbyLeaveReason
		{
			LOBBY_LEAVE_REASON_UNDEFINED = 0,
			LOBBY_LEAVE_REASON_USER_LEFT = 1,
			LOBBY_LEAVE_REASON_LOBBY_CLOSED = 2,
			LOBBY_LEAVE_REASON_CONNECTION_LOST = 3
		}

		private static Dictionary<IntPtr, ILobbyLeftListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyLeftListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyLeftListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyLeftListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyLeftListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyLeftListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyLeft(GalaxyID lobbyID, LobbyLeaveReason leaveReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyLeft(IntPtr cPtr, IntPtr lobbyID, int leaveReason)
		{
		}
	}
}
