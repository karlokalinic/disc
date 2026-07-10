using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyDataRetrieveListener : ILobbyDataRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyDataRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyDataRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyDataRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyDataRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
