using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyDataUpdateListener : ILobbyDataUpdateListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyDataUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyDataUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyDataUpdateListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyDataUpdateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
