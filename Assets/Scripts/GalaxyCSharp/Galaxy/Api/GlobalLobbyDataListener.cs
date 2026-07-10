using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyDataListener : ILobbyDataListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyDataListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyDataListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
