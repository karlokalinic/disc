using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyMemberDataUpdateListener : GalaxyTypeAwareListenerLobbyMemberDataUpdate
	{
		public delegate void SwigDelegateILobbyMemberDataUpdateListener_0(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID);

		public delegate void SwigDelegateILobbyMemberDataUpdateListener_1(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_LOBBY_DOES_NOT_EXIST = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, ILobbyMemberDataUpdateListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyMemberDataUpdateListener_0 swigDelegate0;

		private SwigDelegateILobbyMemberDataUpdateListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ILobbyMemberDataUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyMemberDataUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyMemberDataUpdateListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyMemberDataUpdateListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyMemberDataUpdateSuccess(GalaxyID lobbyID, GalaxyID memberID);

		public abstract void OnLobbyMemberDataUpdateFailure(GalaxyID lobbyID, GalaxyID memberID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyMemberDataUpdateSuccess(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID)
		{
		}

		private static void SwigDirectorOnLobbyMemberDataUpdateFailure(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID, int failureReason)
		{
		}
	}
}
