using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IConnectionOpenListener : GalaxyTypeAwareListenerConnectionOpen
	{
		public delegate void SwigDelegateIConnectionOpenListener_0(IntPtr cPtr, string connectionString, ulong connectionID);

		public delegate void SwigDelegateIConnectionOpenListener_1(IntPtr cPtr, string connectionString, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1,
			FAILURE_REASON_UNAUTHORIZED = 2
		}

		private static Dictionary<IntPtr, IConnectionOpenListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIConnectionOpenListener_0 swigDelegate0;

		private SwigDelegateIConnectionOpenListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IConnectionOpenListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IConnectionOpenListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IConnectionOpenListener obj)
		{
			return default(HandleRef);
		}

		~IConnectionOpenListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnConnectionOpenSuccess(string connectionString, ulong connectionID);

		public abstract void OnConnectionOpenFailure(string connectionString, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnConnectionOpenSuccess(IntPtr cPtr, string connectionString, ulong connectionID)
		{
		}

		private static void SwigDirectorOnConnectionOpenFailure(IntPtr cPtr, string connectionString, int failureReason)
		{
		}
	}
}
