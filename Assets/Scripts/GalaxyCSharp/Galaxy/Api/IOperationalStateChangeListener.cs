using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IOperationalStateChangeListener : GalaxyTypeAwareListenerOperationalStateChange
	{
		public delegate void SwigDelegateIOperationalStateChangeListener_0(IntPtr cPtr, uint operationalState);

		public enum OperationalState
		{
			OPERATIONAL_STATE_SIGNED_IN = 1,
			OPERATIONAL_STATE_LOGGED_ON = 2
		}

		private static Dictionary<IntPtr, IOperationalStateChangeListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIOperationalStateChangeListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IOperationalStateChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IOperationalStateChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IOperationalStateChangeListener obj)
		{
			return default(HandleRef);
		}

		~IOperationalStateChangeListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnOperationalStateChanged(uint operationalState);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnOperationalStateChanged(IntPtr cPtr, uint operationalState)
		{
		}
	}
}
