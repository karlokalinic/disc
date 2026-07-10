using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyMemberDataUpdateListener : ILobbyMemberDataUpdateListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyMemberDataUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyMemberDataUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyMemberDataUpdateListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyMemberDataUpdateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
