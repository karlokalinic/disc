using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IOverlayVisibilityChangeListener : GalaxyTypeAwareListenerOverlayVisibilityChange
	{
		public delegate void SwigDelegateIOverlayVisibilityChangeListener_0(IntPtr cPtr, bool overlayVisible);

		private static Dictionary<IntPtr, IOverlayVisibilityChangeListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIOverlayVisibilityChangeListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IOverlayVisibilityChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IOverlayVisibilityChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IOverlayVisibilityChangeListener obj)
		{
			return default(HandleRef);
		}

		~IOverlayVisibilityChangeListener()
		{
		}

		public override void Dispose()
		{
		}

		public virtual void OnOverlayVisibilityChanged(bool overlayVisible)
		{
		}

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnOverlayVisibilityChanged(IntPtr cPtr, bool overlayVisible)
		{
		}
	}
}
