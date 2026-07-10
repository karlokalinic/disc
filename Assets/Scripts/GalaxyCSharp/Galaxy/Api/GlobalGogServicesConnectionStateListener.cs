using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalGogServicesConnectionStateListener : IGogServicesConnectionStateListener
	{
		private HandleRef swigCPtr;

		internal GlobalGogServicesConnectionStateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalGogServicesConnectionStateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalGogServicesConnectionStateListener obj)
		{
			return default(HandleRef);
		}

		~GlobalGogServicesConnectionStateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
