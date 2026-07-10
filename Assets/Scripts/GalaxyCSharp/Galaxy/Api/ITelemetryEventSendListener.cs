using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ITelemetryEventSendListener : GalaxyTypeAwareListenerTelemetryEventSend
	{
		public delegate void SwigDelegateITelemetryEventSendListener_0(IntPtr cPtr, string eventType, uint sentEventIndex);

		public delegate void SwigDelegateITelemetryEventSendListener_1(IntPtr cPtr, string eventType, uint sentEventIndex, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CLIENT_FORBIDDEN = 1,
			FAILURE_REASON_INVALID_DATA = 2,
			FAILURE_REASON_CONNECTION_FAILURE = 3,
			FAILURE_REASON_NO_SAMPLING_CLASS_IN_CONFIG = 4,
			FAILURE_REASON_SAMPLING_CLASS_FIELD_MISSING = 5,
			FAILURE_REASON_EVENT_SAMPLED_OUT = 6,
			FAILURE_REASON_SAMPLING_RESULT_ALREADY_EXIST = 7,
			FAILURE_REASON_SAMPLING_INVALID_RESULT_PATH = 8
		}

		private static Dictionary<IntPtr, ITelemetryEventSendListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateITelemetryEventSendListener_0 swigDelegate0;

		private SwigDelegateITelemetryEventSendListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ITelemetryEventSendListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ITelemetryEventSendListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ITelemetryEventSendListener obj)
		{
			return default(HandleRef);
		}

		~ITelemetryEventSendListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnTelemetryEventSendSuccess(string eventType, uint sentEventIndex);

		public abstract void OnTelemetryEventSendFailure(string eventType, uint sentEventIndex, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnTelemetryEventSendSuccess(IntPtr cPtr, string eventType, uint sentEventIndex)
		{
		}

		private static void SwigDirectorOnTelemetryEventSendFailure(IntPtr cPtr, string eventType, uint sentEventIndex, int failureReason)
		{
		}
	}
}
