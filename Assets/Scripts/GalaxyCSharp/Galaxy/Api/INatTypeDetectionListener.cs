using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class INatTypeDetectionListener : GalaxyTypeAwareListenerNatTypeDetection
	{
		public delegate void SwigDelegateINatTypeDetectionListener_0(IntPtr cPtr, int natType);

		public delegate void SwigDelegateINatTypeDetectionListener_1(IntPtr cPtr);

		private static Dictionary<IntPtr, INatTypeDetectionListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateINatTypeDetectionListener_0 swigDelegate0;

		private SwigDelegateINatTypeDetectionListener_1 swigDelegate1;

		private static Type[] swigMethodTypes0;

		private static Type[] swigMethodTypes1;

		internal INatTypeDetectionListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public INatTypeDetectionListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(INatTypeDetectionListener obj)
		{
			return default(HandleRef);
		}

		~INatTypeDetectionListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnNatTypeDetectionSuccess(NatType natType);

		public abstract void OnNatTypeDetectionFailure();

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnNatTypeDetectionSuccess(IntPtr cPtr, int natType)
		{
		}

		private static void SwigDirectorOnNatTypeDetectionFailure(IntPtr cPtr)
		{
		}
	}
}
