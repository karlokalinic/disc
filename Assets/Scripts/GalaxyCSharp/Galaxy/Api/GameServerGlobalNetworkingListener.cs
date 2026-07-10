using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalNetworkingListener : INetworkingListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalNetworkingListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalNetworkingListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalNetworkingListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalNetworkingListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
