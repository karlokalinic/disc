using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyDataUpdateListener : ILobbyDataUpdateListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyDataUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyDataUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyDataUpdateListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyDataUpdateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
