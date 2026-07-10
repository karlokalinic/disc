using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IUserFindListener : GalaxyTypeAwareListenerUserFind
	{
		public delegate void SwigDelegateIUserFindListener_0(IntPtr cPtr, string userSpecifier, IntPtr userID);

		public delegate void SwigDelegateIUserFindListener_1(IntPtr cPtr, string userSpecifier, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_USER_NOT_FOUND = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2
		}

		private static Dictionary<IntPtr, IUserFindListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIUserFindListener_0 swigDelegate0;

		private SwigDelegateIUserFindListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IUserFindListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IUserFindListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IUserFindListener obj)
		{
			return default(HandleRef);
		}

		~IUserFindListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnUserFindSuccess(string userSpecifier, GalaxyID userID);

		public abstract void OnUserFindFailure(string userSpecifier, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnUserFindSuccess(IntPtr cPtr, string userSpecifier, IntPtr userID)
		{
		}

		private static void SwigDirectorOnUserFindFailure(IntPtr cPtr, string userSpecifier, int failureReason)
		{
		}
	}
}
