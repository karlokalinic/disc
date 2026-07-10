using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyEnteredListener : ILobbyEnteredListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyEnteredListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyEnteredListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyEnteredListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyEnteredListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
