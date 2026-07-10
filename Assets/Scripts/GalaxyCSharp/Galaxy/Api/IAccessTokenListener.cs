using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IAccessTokenListener : GalaxyTypeAwareListenerAccessToken
	{
		public delegate void SwigDelegateIAccessTokenListener_0(IntPtr cPtr);

		private static Dictionary<IntPtr, IAccessTokenListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIAccessTokenListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IAccessTokenListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IAccessTokenListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IAccessTokenListener obj)
		{
			return default(HandleRef);
		}

		~IAccessTokenListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnAccessTokenChanged();

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnAccessTokenChanged(IntPtr cPtr)
		{
		}
	}
}
