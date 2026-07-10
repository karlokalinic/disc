using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IConnectionDataListener : GalaxyTypeAwareListenerConnectionData
	{
		public delegate void SwigDelegateIConnectionDataListener_0(IntPtr cPtr, ulong connectionID, uint dataSize);

		private static Dictionary<IntPtr, IConnectionDataListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIConnectionDataListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IConnectionDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IConnectionDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IConnectionDataListener obj)
		{
			return default(HandleRef);
		}

		~IConnectionDataListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnConnectionDataReceived(ulong connectionID, uint dataSize);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnConnectionDataReceived(IntPtr cPtr, ulong connectionID, uint dataSize)
		{
		}
	}
}
