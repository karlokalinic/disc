using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyEnteredListener : ILobbyEnteredListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyEnteredListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyEnteredListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyEnteredListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyEnteredListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
