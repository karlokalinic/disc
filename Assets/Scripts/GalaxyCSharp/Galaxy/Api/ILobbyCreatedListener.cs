using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyCreatedListener : GalaxyTypeAwareListenerLobbyCreated
	{
		public delegate void SwigDelegateILobbyCreatedListener_0(IntPtr cPtr, IntPtr lobbyID, int _result);

		private static Dictionary<IntPtr, ILobbyCreatedListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyCreatedListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyCreatedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyCreatedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyCreatedListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyCreatedListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyCreated(GalaxyID lobbyID, LobbyCreateResult _result);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyCreated(IntPtr cPtr, IntPtr lobbyID, int _result)
		{
		}
	}
}
