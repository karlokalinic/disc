using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalLobbyDataRetrieveListener : ILobbyDataRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalLobbyDataRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalLobbyDataRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalLobbyDataRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalLobbyDataRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
