using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyEnteredListener : GalaxyTypeAwareListenerLobbyEntered
	{
		public delegate void SwigDelegateILobbyEnteredListener_0(IntPtr cPtr, IntPtr lobbyID, int _result);

		private static Dictionary<IntPtr, ILobbyEnteredListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyEnteredListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyEnteredListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyEnteredListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyEnteredListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyEnteredListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyEntered(GalaxyID lobbyID, LobbyEnterResult _result);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyEntered(IntPtr cPtr, IntPtr lobbyID, int _result)
		{
		}
	}
}
