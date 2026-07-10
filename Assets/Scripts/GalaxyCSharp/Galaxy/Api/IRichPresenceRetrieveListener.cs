using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IRichPresenceRetrieveListener : GalaxyTypeAwareListenerRichPresenceRetrieve
	{
		public delegate void SwigDelegateIRichPresenceRetrieveListener_0(IntPtr cPtr, IntPtr userID);

		public delegate void SwigDelegateIRichPresenceRetrieveListener_1(IntPtr cPtr, IntPtr userID, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IRichPresenceRetrieveListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIRichPresenceRetrieveListener_0 swigDelegate0;

		private SwigDelegateIRichPresenceRetrieveListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IRichPresenceRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IRichPresenceRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IRichPresenceRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~IRichPresenceRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}

		public virtual void OnRichPresenceRetrieveSuccess(GalaxyID userID)
		{
		}

		public virtual void OnRichPresenceRetrieveFailure(GalaxyID userID, FailureReason failureReason)
		{
		}

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnRichPresenceRetrieveSuccess(IntPtr cPtr, IntPtr userID)
		{
		}

		private static void SwigDirectorOnRichPresenceRetrieveFailure(IntPtr cPtr, IntPtr userID, int failureReason)
		{
		}
	}
}
