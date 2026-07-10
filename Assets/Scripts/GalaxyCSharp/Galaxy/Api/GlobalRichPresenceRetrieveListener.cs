using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalRichPresenceRetrieveListener : IRichPresenceRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalRichPresenceRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalRichPresenceRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalRichPresenceRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalRichPresenceRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
