using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IConnectionCloseListener : GalaxyTypeAwareListenerConnectionClose
	{
		public delegate void SwigDelegateIConnectionCloseListener_0(IntPtr cPtr, ulong connectionID, int closeReason);

		public enum CloseReason
		{
			CLOSE_REASON_UNDEFINED = 0
		}

		private static Dictionary<IntPtr, IConnectionCloseListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIConnectionCloseListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IConnectionCloseListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IConnectionCloseListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IConnectionCloseListener obj)
		{
			return default(HandleRef);
		}

		~IConnectionCloseListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnConnectionClosed(ulong connectionID, CloseReason closeReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnConnectionClosed(IntPtr cPtr, ulong connectionID, int closeReason)
		{
		}
	}
}
