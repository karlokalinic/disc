using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalNotificationListener : INotificationListener
	{
		private HandleRef swigCPtr;

		internal GlobalNotificationListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalNotificationListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalNotificationListener obj)
		{
			return default(HandleRef);
		}

		~GlobalNotificationListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
