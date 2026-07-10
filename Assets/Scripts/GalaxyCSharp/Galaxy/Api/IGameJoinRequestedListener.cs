using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IGameJoinRequestedListener : GalaxyTypeAwareListenerGameJoinRequested
	{
		public delegate void SwigDelegateIGameJoinRequestedListener_0(IntPtr cPtr, IntPtr userID, string connectionString);

		private static Dictionary<IntPtr, IGameJoinRequestedListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIGameJoinRequestedListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IGameJoinRequestedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IGameJoinRequestedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IGameJoinRequestedListener obj)
		{
			return default(HandleRef);
		}

		~IGameJoinRequestedListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnGameJoinRequested(GalaxyID userID, string connectionString);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnGameJoinRequested(IntPtr cPtr, IntPtr userID, string connectionString)
		{
		}
	}
}
