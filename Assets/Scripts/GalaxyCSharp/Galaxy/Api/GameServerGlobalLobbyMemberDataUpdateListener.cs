using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyMemberDataUpdateListener : ILobbyMemberDataUpdateListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyMemberDataUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyMemberDataUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyMemberDataUpdateListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyMemberDataUpdateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
