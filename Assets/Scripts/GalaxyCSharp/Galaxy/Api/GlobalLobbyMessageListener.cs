using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyMessageListener : ILobbyMessageListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyMessageListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyMessageListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyMessageListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyMessageListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
