using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyListListener : ILobbyListListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyListListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyListListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyListListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyListListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
