using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalAccessTokenListener : IAccessTokenListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalAccessTokenListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalAccessTokenListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalAccessTokenListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalAccessTokenListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
