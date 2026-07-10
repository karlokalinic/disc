using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ICloudStorageGetFileListListener : GalaxyTypeAwareListenerCloudStorageGetFileList
	{
		public delegate void SwigDelegateICloudStorageGetFileListListener_0(IntPtr cPtr, uint fileCount, uint quota, uint quotaUsed);

		public delegate void SwigDelegateICloudStorageGetFileListListener_1(IntPtr cPtr, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_UNAUTHORIZED = 1,
			FAILURE_REASON_FORBIDDEN = 2,
			FAILURE_REASON_NOT_FOUND = 3,
			FAILURE_REASON_UNAVAILABLE = 4,
			FAILURE_REASON_ABORTED = 5,
			FAILURE_REASON_CONNECTION_FAILURE = 6
		}

		private static Dictionary<IntPtr, ICloudStorageGetFileListListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateICloudStorageGetFileListListener_0 swigDelegate0;

		private SwigDelegateICloudStorageGetFileListListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ICloudStorageGetFileListListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ICloudStorageGetFileListListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ICloudStorageGetFileListListener obj)
		{
			return default(HandleRef);
		}

		~ICloudStorageGetFileListListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnGetFileListSuccess(uint fileCount, uint quota, uint quotaUsed);

		public abstract void OnGetFileListFailure(FailureReason failureReason);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnGetFileListSuccess(IntPtr cPtr, uint fileCount, uint quota, uint quotaUsed)
		{
		}

		private static void SwigDirectorOnGetFileListFailure(IntPtr cPtr, int failureReason)
		{
		}
	}
}
