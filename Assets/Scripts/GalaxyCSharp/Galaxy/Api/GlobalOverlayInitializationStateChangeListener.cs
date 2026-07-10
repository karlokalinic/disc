using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalOverlayInitializationStateChangeListener : IOverlayInitializationStateChangeListener
	{
		private static Dictionary<IntPtr, GlobalOverlayInitializationStateChangeListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalOverlayInitializationStateChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalOverlayInitializationStateChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalOverlayInitializationStateChangeListener obj)
		{
			return default(HandleRef);
		}

		~GlobalOverlayInitializationStateChangeListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
