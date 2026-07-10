using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalRichPresenceRetrieveListener : IRichPresenceRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalRichPresenceRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalRichPresenceRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalRichPresenceRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalRichPresenceRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
