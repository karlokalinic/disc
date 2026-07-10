using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFriendListListener : IFriendListListener
	{
		private HandleRef swigCPtr;

		internal GlobalFriendListListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFriendListListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFriendListListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFriendListListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
