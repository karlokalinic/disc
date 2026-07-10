using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyDataListener : GalaxyTypeAwareListenerLobbyData
	{
		public delegate void SwigDelegateILobbyDataListener_0(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID);

		private static Dictionary<IntPtr, ILobbyDataListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyDataListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyDataListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyDataListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyDataUpdated(GalaxyID lobbyID, GalaxyID memberID);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyDataUpdated(IntPtr cPtr, IntPtr lobbyID, IntPtr memberID)
		{
		}
	}
}
