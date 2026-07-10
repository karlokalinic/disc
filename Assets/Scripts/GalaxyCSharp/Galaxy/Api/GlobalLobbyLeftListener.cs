using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLobbyLeftListener : ILobbyLeftListener
	{
		private HandleRef swigCPtr;

		internal GlobalLobbyLeftListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLobbyLeftListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLobbyLeftListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLobbyLeftListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
