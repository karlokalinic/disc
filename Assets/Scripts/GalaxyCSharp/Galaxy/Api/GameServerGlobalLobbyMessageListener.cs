using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyMessageListener : ILobbyMessageListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyMessageListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyMessageListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyMessageListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyMessageListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
