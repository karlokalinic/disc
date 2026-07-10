using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ILobbyMessageListener : GalaxyTypeAwareListenerLobbyMessage
	{
		public delegate void SwigDelegateILobbyMessageListener_0(IntPtr cPtr, IntPtr lobbyID, IntPtr senderID, uint messageID, uint messageLength);

		private static Dictionary<IntPtr, ILobbyMessageListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateILobbyMessageListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal ILobbyMessageListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ILobbyMessageListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ILobbyMessageListener obj)
		{
			return default(HandleRef);
		}

		~ILobbyMessageListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnLobbyMessageReceived(GalaxyID lobbyID, GalaxyID senderID, uint messageID, uint messageLength);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnLobbyMessageReceived(IntPtr cPtr, IntPtr lobbyID, IntPtr senderID, uint messageID, uint messageLength)
		{
		}
	}
}
