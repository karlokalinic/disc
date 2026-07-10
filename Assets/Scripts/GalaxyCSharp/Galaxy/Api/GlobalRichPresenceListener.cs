using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalRichPresenceListener : IRichPresenceListener
	{
		private HandleRef swigCPtr;

		internal GlobalRichPresenceListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalRichPresenceListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalRichPresenceListener obj)
		{
			return default(HandleRef);
		}

		~GlobalRichPresenceListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
