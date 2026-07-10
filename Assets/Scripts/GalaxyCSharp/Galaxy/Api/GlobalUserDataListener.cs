using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalUserDataListener : IUserDataListener
	{
		private HandleRef swigCPtr;

		internal GlobalUserDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalUserDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalUserDataListener obj)
		{
			return default(HandleRef);
		}

		~GlobalUserDataListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
