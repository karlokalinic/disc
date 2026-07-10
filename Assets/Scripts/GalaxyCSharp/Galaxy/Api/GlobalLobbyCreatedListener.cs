using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyCreatedListener : ILobbyCreatedListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyCreatedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyCreatedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyCreatedListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyCreatedListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
