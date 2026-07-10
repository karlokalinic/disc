using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFriendDeleteListener : IFriendDeleteListener
	{
		private HandleRef swigCPtr;

		internal GlobalFriendDeleteListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFriendDeleteListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFriendDeleteListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFriendDeleteListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
