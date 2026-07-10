using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalNetworkingListener : INetworkingListener
	{
		private HandleRef swigCPtr;

		internal GlobalNetworkingListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalNetworkingListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalNetworkingListener obj)
		{
			return default(HandleRef);
		}

		~GlobalNetworkingListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
