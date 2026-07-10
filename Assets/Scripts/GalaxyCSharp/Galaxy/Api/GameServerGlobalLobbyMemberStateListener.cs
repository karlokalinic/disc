using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyMemberStateListener : ILobbyMemberStateListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyMemberStateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyMemberStateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyMemberStateListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyMemberStateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
