using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class INetworkingListener : GalaxyTypeAwareListenerNetworking
	{
		public delegate void SwigDelegateINetworkingListener_0(IntPtr cPtr, uint msgSize, byte channel);

		private static Dictionary<IntPtr, INetworkingListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateINetworkingListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal INetworkingListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public INetworkingListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(INetworkingListener obj)
		{
			return default(HandleRef);
		}

		~INetworkingListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnP2PPacketAvailable(uint msgSize, byte channel);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnP2PPacketAvailable(IntPtr cPtr, uint msgSize, byte channel)
		{
		}
	}
}
