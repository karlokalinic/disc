using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalAuthListener : IAuthListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalAuthListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalAuthListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalAuthListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalAuthListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
