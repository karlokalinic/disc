using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyOwnerChangeListener : GalaxyTypeAwareListenerLobbyOwnerChange
	{
		public delegate void SwigDelegateILobbyOwnerChangeListener_0(IntPtr cPtr, IntPtr lobbyID, IntPtr newOwnerID);

		private static Dictionary<IntPtr, ILobbyOwnerChangeListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyOwnerChangeListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyOwnerChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyOwnerChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyOwnerChangeListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyOwnerChangeListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyOwnerChanged(GalaxyID lobbyID, GalaxyID newOwnerID);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyOwnerChanged(IntPtr cPtr, IntPtr lobbyID, IntPtr newOwnerID)
		{
		}
	}
}
