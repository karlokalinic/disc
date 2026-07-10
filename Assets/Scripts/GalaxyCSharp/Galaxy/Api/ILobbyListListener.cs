using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyListListener : GalaxyTypeAwareListenerLobbyList
	{
		public delegate void SwigDelegateILobbyListListener_0(IntPtr cPtr, uint lobbyCount, int _result);

		private static Dictionary<IntPtr, ILobbyListListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyListListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyListListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyListListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyListListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyListListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyList(uint lobbyCount, LobbyListResult _result);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyList(IntPtr cPtr, uint lobbyCount, int _result)
		{
		}
	}
}
