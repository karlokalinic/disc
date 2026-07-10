using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IUserTimePlayedRetrieveListener : GalaxyTypeAwareListenerUserTimePlayedRetrieve
	{
		public delegate void SwigDelegateIUserTimePlayedRetrieveListener_0(IntPtr cPtr, IntPtr userID);

		public delegate void SwigDelegateIUserTimePlayedRetrieveListener_1(IntPtr cPtr, IntPtr userID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IUserTimePlayedRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIUserTimePlayedRetrieveListener_0 swigDelegate0;

		private SwigDelegateIUserTimePlayedRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IUserTimePlayedRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IUserTimePlayedRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IUserTimePlayedRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~IUserTimePlayedRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnUserTimePlayedRetrieveSuccess(GalaxyID userID);

		public abstract void OnUserTimePlayedRetrieveFailure(GalaxyID userID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnUserTimePlayedRetrieveSuccess(IntPtr cPtr, IntPtr userID)
		{
		}

		private static void SwigDirectorOnUserTimePlayedRetrieveFailure(IntPtr cPtr, IntPtr userID, int failureReason)
		{
		}
	}
}
