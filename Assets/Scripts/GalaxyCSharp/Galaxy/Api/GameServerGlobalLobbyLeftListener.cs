using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyLeftListener : ILobbyLeftListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyLeftListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyLeftListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyLeftListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyLeftListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
