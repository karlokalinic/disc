using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalOverlayVisibilityChangeListener : IOverlayVisibilityChangeListener
	{
		private HandleRef swigCPtr;

		internal GlobalOverlayVisibilityChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalOverlayVisibilityChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalOverlayVisibilityChangeListener obj)
		{
			return default(HandleRef);
		}

		~GlobalOverlayVisibilityChangeListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
