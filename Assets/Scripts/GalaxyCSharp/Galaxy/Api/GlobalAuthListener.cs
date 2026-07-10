using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalAuthListener : IAuthListener
	{
		private HandleRef swigCPtr;

		internal GlobalAuthListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalAuthListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalAuthListener obj)
		{
			return default(HandleRef);
		}

		~GlobalAuthListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
