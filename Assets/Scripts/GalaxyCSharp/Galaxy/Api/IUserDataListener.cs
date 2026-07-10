using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IUserDataListener : GalaxyTypeAwareListenerUserData
	{
		public delegate void SwigDelegateIUserDataListener_0(IntPtr cPtr);

		private static Dictionary<IntPtr, IUserDataListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIUserDataListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IUserDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IUserDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IUserDataListener obj)
		{
			return default(HandleRef);
		}

		~IUserDataListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnUserDataUpdated();

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnUserDataUpdated(IntPtr cPtr)
		{
		}
	}
}
