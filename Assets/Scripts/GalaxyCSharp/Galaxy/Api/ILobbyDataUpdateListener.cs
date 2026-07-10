using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyDataUpdateListener : GalaxyTypeAwareListenerLobbyDataUpdate
	{
		public delegate void SwigDelegateILobbyDataUpdateListener_0(IntPtr cPtr, IntPtr lobbyID);

		public delegate void SwigDelegateILobbyDataUpdateListener_1(IntPtr cPtr, IntPtr lobbyID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_LOBBY_DOES_NOT_EXIST = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, ILobbyDataUpdateListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyDataUpdateListener_0 swigDelegate0;

		private SwigDelegateILobbyDataUpdateListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ILobbyDataUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyDataUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyDataUpdateListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyDataUpdateListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyDataUpdateSuccess(GalaxyID lobbyID);

		public abstract void OnLobbyDataUpdateFailure(GalaxyID lobbyID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyDataUpdateSuccess(IntPtr cPtr, IntPtr lobbyID)
		{
		}

		private static void SwigDirectorOnLobbyDataUpdateFailure(IntPtr cPtr, IntPtr lobbyID, int failureReason)
		{
		}
	}
}
