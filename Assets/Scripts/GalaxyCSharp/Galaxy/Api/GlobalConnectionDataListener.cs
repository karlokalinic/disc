using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalConnectionDataListener : IConnectionDataListener
	{
		private HandleRef swigCPtr;

		internal GlobalConnectionDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalConnectionDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalConnectionDataListener obj)
		{
			return default(HandleRef);
		}

		~GlobalConnectionDataListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
