using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalConnectionCloseListener : IConnectionCloseListener
	{
		private HandleRef swigCPtr;

		internal GlobalConnectionCloseListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalConnectionCloseListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalConnectionCloseListener obj)
		{
			return default(HandleRef);
		}

		~GlobalConnectionCloseListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
