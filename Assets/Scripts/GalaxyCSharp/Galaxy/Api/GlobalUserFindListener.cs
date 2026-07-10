using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalUserFindListener : IUserFindListener
	{
		private HandleRef swigCPtr;

		internal GlobalUserFindListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalUserFindListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalUserFindListener obj)
		{
			return default(HandleRef);
		}

		~GlobalUserFindListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
