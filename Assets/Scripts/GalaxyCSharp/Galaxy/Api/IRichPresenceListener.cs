using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IRichPresenceListener : GalaxyTypeAwareListenerRichPresence
	{
		public delegate void SwigDelegateIRichPresenceListener_0(IntPtr cPtr, IntPtr userID);

		private static Dictionary<IntPtr, IRichPresenceListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIRichPresenceListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IRichPresenceListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IRichPresenceListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IRichPresenceListener obj)
		{
			return default(HandleRef);
		}

		~IRichPresenceListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnRichPresenceUpdated(GalaxyID userID);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnRichPresenceUpdated(IntPtr cPtr, IntPtr userID)
		{
		}
	}
}
