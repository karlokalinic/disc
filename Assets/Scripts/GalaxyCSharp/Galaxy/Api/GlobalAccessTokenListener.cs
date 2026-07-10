using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalAccessTokenListener : IAccessTokenListener
	{
		private HandleRef swigCPtr;

		internal GlobalAccessTokenListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalAccessTokenListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalAccessTokenListener obj)
		{
			return default(HandleRef);
		}

		~GlobalAccessTokenListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
