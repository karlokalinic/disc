using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalGogServicesConnectionStateListener : IGogServicesConnectionStateListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalGogServicesConnectionStateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalGogServicesConnectionStateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalGogServicesConnectionStateListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalGogServicesConnectionStateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
