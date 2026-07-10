using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ICloudStoragePutFileListener : GalaxyTypeAwareListenerCloudStoragePutFile
	{
		public delegate void SwigDelegateICloudStoragePutFileListener_0(IntPtr cPtr, string container, string name);

		public delegate void SwigDelegateICloudStoragePutFileListener_1(IntPtr cPtr, string container, string name, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_UNAUTHORIZED = 1,
			FAILURE_REASON_FORBIDDEN = 2,
			FAILURE_REASON_UNAVAILABLE = 3,
			FAILURE_REASON_ABORTED = 4,
			FAILURE_REASON_CONNECTION_FAILURE = 5,
			FAILURE_REASON_READ_FUNC_ERROR = 6,
			FAILURE_REASON_QUOTA_EXCEEDED = 7
		}

		private static Dictionary<IntPtr, ICloudStoragePutFileListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateICloudStoragePutFileListener_0 swigDelegate0;

		private SwigDelegateICloudStoragePutFileListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ICloudStoragePutFileListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ICloudStoragePutFileListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ICloudStoragePutFileListener obj)
		{
			return default(HandleRef);
		}

		~ICloudStoragePutFileListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnPutFileSuccess(string container, string name);

		public abstract void OnPutFileFailure(string container, string name, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnPutFileSuccess(IntPtr cPtr, string container, string name)
		{
		}

		private static void SwigDirectorOnPutFileFailure(IntPtr cPtr, string container, string name, int failureReason)
		{
		}
	}
}
