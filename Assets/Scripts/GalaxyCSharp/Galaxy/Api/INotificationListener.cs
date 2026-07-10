using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class INotificationListener : GalaxyTypeAwareListenerNotification
	{
		public delegate void SwigDelegateINotificationListener_0(IntPtr cPtr, ulong notificationID, uint typeLength, uint contentSize);

		private static Dictionary<IntPtr, INotificationListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateINotificationListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal INotificationListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public INotificationListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(INotificationListener obj)
		{
			return default(HandleRef);
		}

		~INotificationListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnNotificationReceived(ulong notificationID, uint typeLength, uint contentSize);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnNotificationReceived(IntPtr cPtr, ulong notificationID, uint typeLength, uint contentSize)
		{
		}
	}
}
