using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class ICloudStorageGetFileListener : GalaxyTypeAwareListenerCloudStorageGetFile
	{
		public delegate void SwigDelegateICloudStorageGetFileListener_0(IntPtr cPtr, string container, string name, uint fileSize, int savegameType, string savegameID);

		public delegate void SwigDelegateICloudStorageGetFileListener_1(IntPtr cPtr, string container, string name, int failureReason);

		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_UNAUTHORIZED = 1,
			FAILURE_REASON_FORBIDDEN = 2,
			FAILURE_REASON_NOT_FOUND = 3,
			FAILURE_REASON_UNAVAILABLE = 4,
			FAILURE_REASON_ABORTED = 5,
			FAILURE_REASON_CONNECTION_FAILURE = 6,
			FAILURE_REASON_BUFFER_TOO_SMALL = 7,
			FAILURE_REASON_WRITE_FUNC_ERROR = 8
		}

		private static Dictionary<IntPtr, ICloudStorageGetFileListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateICloudStorageGetFileListener_0 swigDelegate0;

		private SwigDelegateICloudStorageGetFileListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal ICloudStorageGetFileListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public ICloudStorageGetFileListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(ICloudStorageGetFileListener obj)
		{
			return default(HandleRef);
		}

		~ICloudStorageGetFileListener()
		{
		}

		public override void Dispose()
		{
		}

		public virtual void OnGetFileSuccess(string container, string name, uint fileSize, SavegameType savegameType, string savegameID)
		{
		}

		public virtual void OnGetFileFailure(string container, string name, FailureReason failureReason)
		{
		}

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnGetFileSuccess(IntPtr cPtr, string container, string name, uint fileSize, int savegameType, string savegameID)
		{
		}

		private static void SwigDirectorOnGetFileFailure(IntPtr cPtr, string container, string name, int failureReason)
		{
		}
	}
}
