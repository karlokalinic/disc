using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IFriendDeleteListener : GalaxyTypeAwareListenerFriendDelete
	{
		public delegate void SwigDelegateIFriendDeleteListener_0(IntPtr cPtr, IntPtr userID);

		public delegate void SwigDelegateIFriendDeleteListener_1(IntPtr cPtr, IntPtr userID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IFriendDeleteListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIFriendDeleteListener_0 swigDelegate0;

		private SwigDelegateIFriendDeleteListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IFriendDeleteListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IFriendDeleteListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IFriendDeleteListener obj)
		{
			return default(HandleRef);
		}

		~IFriendDeleteListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnFriendDeleteSuccess(GalaxyID userID);

		public abstract void OnFriendDeleteFailure(GalaxyID userID, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnFriendDeleteSuccess(IntPtr cPtr, IntPtr userID)
		{
		}

		private static void SwigDirectorOnFriendDeleteFailure(IntPtr cPtr, IntPtr userID, int failureReason)
		{
		}
	}
}
