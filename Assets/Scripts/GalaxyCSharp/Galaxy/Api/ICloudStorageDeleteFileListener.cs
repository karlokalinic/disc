using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ICloudStorageDeleteFileListener : GalaxyTypeAwareListenerCloudStorageDeleteFile
	{
		public delegate void SwigDelegateICloudStorageDeleteFileListener_0(IntPtr cPtr, string container, string name);

		public delegate void SwigDelegateICloudStorageDeleteFileListener_1(IntPtr cPtr, string container, string name, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_UNAUTHORIZED = 1,
			FAILURE_REASON_FORBIDDEN = 2,
			FAILURE_REASON_NOT_FOUND = 3,
			FAILURE_REASON_UNAVAILABLE = 4,
			FAILURE_REASON_ABORTED = 5,
			FAILURE_REASON_CONNECTION_FAILURE = 6,
			FAILURE_REASON_CONFLICT = 7
		}

		private static Dictionary<IntPtr, ICloudStorageDeleteFileListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateICloudStorageDeleteFileListener_0 swigDelegate0;

		private SwigDelegateICloudStorageDeleteFileListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ICloudStorageDeleteFileListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ICloudStorageDeleteFileListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ICloudStorageDeleteFileListener obj)
		{
			return default(HandleRef);
		}

		~ICloudStorageDeleteFileListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnDeleteFileSuccess(string container, string name);

		public abstract void OnDeleteFileFailure(string container, string name, FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnDeleteFileSuccess(IntPtr cPtr, string container, string name)
		{
		}

		private static void SwigDirectorOnDeleteFileFailure(IntPtr cPtr, string container, string name, int failureReason)
		{
		}
	}
}
