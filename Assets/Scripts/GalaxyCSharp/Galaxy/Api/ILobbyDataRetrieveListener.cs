using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyDataRetrieveListener : GalaxyTypeAwareListenerLobbyDataRetrieve
	{
		public delegate void SwigDelegateILobbyDataRetrieveListener_0(IntPtr cPtr, IntPtr lobbyID);

		public delegate void SwigDelegateILobbyDataRetrieveListener_1(IntPtr cPtr, IntPtr lobbyID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_LOBBY_DOES_NOT_EXIST = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, ILobbyDataRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyDataRetrieveListener_0 swigDelegate0;

		private SwigDelegateILobbyDataRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ILobbyDataRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyDataRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyDataRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyDataRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyDataRetrieveSuccess(GalaxyID lobbyID);

		public abstract void OnLobbyDataRetrieveFailure(GalaxyID lobbyID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyDataRetrieveSuccess(IntPtr cPtr, IntPtr lobbyID)
		{
		}

		private static void SwigDirectorOnLobbyDataRetrieveFailure(IntPtr cPtr, IntPtr lobbyID, int failureReason)
		{
		}
	}
}
