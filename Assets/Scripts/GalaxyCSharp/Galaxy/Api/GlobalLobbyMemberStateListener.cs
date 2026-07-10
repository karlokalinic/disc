using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyMemberStateListener : ILobbyMemberStateListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyMemberStateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyMemberStateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyMemberStateListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyMemberStateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
