using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalOtherSessionStartListener : IOtherSessionStartListener
	{
		private HandleRef swigCPtr;

		internal GlobalOtherSessionStartListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalOtherSessionStartListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalOtherSessionStartListener obj)
		{
			return default(HandleRef);
		}

		~GlobalOtherSessionStartListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
