using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalConnectionOpenListener : IConnectionOpenListener
	{
		private HandleRef swigCPtr;

		internal GlobalConnectionOpenListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalConnectionOpenListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalConnectionOpenListener obj)
		{
			return default(HandleRef);
		}

		~GlobalConnectionOpenListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
