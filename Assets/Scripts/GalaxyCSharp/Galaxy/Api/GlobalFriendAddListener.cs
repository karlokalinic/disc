using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFriendAddListener : IFriendAddListener
	{
		private HandleRef swigCPtr;

		internal GlobalFriendAddListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFriendAddListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFriendAddListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFriendAddListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
