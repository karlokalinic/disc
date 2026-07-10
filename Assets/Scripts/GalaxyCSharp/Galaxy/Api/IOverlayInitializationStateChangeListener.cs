using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IOverlayInitializationStateChangeListener : GalaxyTypeAwareListenerOverlayInitializationStateChange
	{
		public delegate void SwigDelegateIOverlayInitializationStateChangeListener_0(IntPtr cPtr, int overlayState);

		private static Dictionary<IntPtr, IOverlayInitializationStateChangeListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIOverlayInitializationStateChangeListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IOverlayInitializationStateChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IOverlayInitializationStateChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IOverlayInitializationStateChangeListener obj)
		{
			return default(HandleRef);
		}

		~IOverlayInitializationStateChangeListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnOverlayStateChanged(OverlayState overlayState);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnOverlayStateChanged(IntPtr cPtr, int overlayState)
		{
		}
	}
}
