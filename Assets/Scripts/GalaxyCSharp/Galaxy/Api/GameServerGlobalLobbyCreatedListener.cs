using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyCreatedListener : ILobbyCreatedListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyCreatedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyCreatedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyCreatedListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyCreatedListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
