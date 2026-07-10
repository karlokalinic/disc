using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IIsDlcOwnedListener : GalaxyTypeAwareListenerIsDlcOwned
	{
		public delegate void SwigDelegateIIsDlcOwnedListener_0(IntPtr cPtr, ulong productId, bool isOwned);

		public delegate void SwigDelegateIIsDlcOwnedListener_1(IntPtr cPtr, ulong productId, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_GALAXY_SERVICE_NOT_SIGNED_IN = 1,
			FAILURE_REASON_CONNECTION_FAILURE = 2,
			FAILURE_REASON_EXTERNAL_SERVICE_FAILURE = 3
		}

		private static Dictionary<IntPtr, IIsDlcOwnedListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIIsDlcOwnedListener_0 swigDelegate0;

		private SwigDelegateIIsDlcOwnedListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IIsDlcOwnedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IIsDlcOwnedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IIsDlcOwnedListener obj)
		{
			return default(HandleRef);
		}

		~IIsDlcOwnedListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnDlcCheckSuccess(ulong productId, bool isOwned);

		public abstract void OnDlcCheckFailure(ulong productId, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnDlcCheckSuccess(IntPtr cPtr, ulong productId, bool isOwned)
		{
		}

		private static void SwigDirectorOnDlcCheckFailure(IntPtr cPtr, ulong productId, int failureReason)
		{
		}
	}
}
