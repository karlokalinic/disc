using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyOwnerChangeListener : ILobbyOwnerChangeListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyOwnerChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyOwnerChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyOwnerChangeListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyOwnerChangeListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
