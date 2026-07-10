using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IEncryptedAppTicketListener : GalaxyTypeAwareListenerEncryptedAppTicket
	{
		public delegate void SwigDelegateIEncryptedAppTicketListener_0(IntPtr cPtr);

		public delegate void SwigDelegateIEncryptedAppTicketListener_1(IntPtr cPtr, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IEncryptedAppTicketListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIEncryptedAppTicketListener_0 swigDelegate0;

		private SwigDelegateIEncryptedAppTicketListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal IEncryptedAppTicketListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IEncryptedAppTicketListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IEncryptedAppTicketListener obj)
		{
			return default(HandleRef);
		}

		~IEncryptedAppTicketListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnEncryptedAppTicketRetrieveSuccess();

		public virtual void OnEncryptedAppTicketRetrieveFailure(FailureReason failureReason)
		{
		}

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnEncryptedAppTicketRetrieveSuccess(IntPtr cPtr)
		{
		}

		private static void SwigDirectorOnEncryptedAppTicketRetrieveFailure(IntPtr cPtr, int failureReason)
		{
		}
	}
}
