using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyDataListener : ILobbyDataListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyDataListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyDataListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
