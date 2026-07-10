using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IOtherSessionStartListener : GalaxyTypeAwareListenerOtherSessionStart
	{
		public delegate void SwigDelegateIOtherSessionStartListener_0(IntPtr cPtr);

		private static Dictionary<IntPtr, IOtherSessionStartListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIOtherSessionStartListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IOtherSessionStartListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IOtherSessionStartListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IOtherSessionStartListener obj)
		{
			return default(HandleRef);
		}

		~IOtherSessionStartListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnOtherSessionStarted();

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnOtherSessionStarted(IntPtr cPtr)
		{
		}
	}
}
