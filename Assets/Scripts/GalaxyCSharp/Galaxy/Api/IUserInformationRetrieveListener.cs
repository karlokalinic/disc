using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IUserInformationRetrieveListener : GalaxyTypeAwareListenerUserInformationRetrieve
	{
		public delegate void SwigDelegateIUserInformationRetrieveListener_0(IntPtr cPtr, IntPtr userID);

		public delegate void SwigDelegateIUserInformationRetrieveListener_1(IntPtr cPtr, IntPtr userID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IUserInformationRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIUserInformationRetrieveListener_0 swigDelegate0;

		private SwigDelegateIUserInformationRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IUserInformationRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IUserInformationRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IUserInformationRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~IUserInformationRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnUserInformationRetrieveSuccess(GalaxyID userID);

		public abstract void OnUserInformationRetrieveFailure(GalaxyID userID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnUserInformationRetrieveSuccess(IntPtr cPtr, IntPtr userID)
		{
		}

		private static void SwigDirectorOnUserInformationRetrieveFailure(IntPtr cPtr, IntPtr userID, int failureReason)
		{
		}
	}
}
