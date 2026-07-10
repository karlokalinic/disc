using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalRichPresenceChangeListener : IRichPresenceChangeListener
	{
		private HandleRef swigCPtr;

		internal GlobalRichPresenceChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalRichPresenceChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalRichPresenceChangeListener obj)
		{
			return default(HandleRef);
		}

		~GlobalRichPresenceChangeListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
