using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalGameJoinRequestedListener : IGameJoinRequestedListener
	{
		private HandleRef swigCPtr;

		internal GlobalGameJoinRequestedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalGameJoinRequestedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalGameJoinRequestedListener obj)
		{
			return default(HandleRef);
		}

		~GlobalGameJoinRequestedListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
