using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalOperationalStateChangeListener : IOperationalStateChangeListener
	{
		private HandleRef swigCPtr;

		internal GlobalOperationalStateChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalOperationalStateChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalOperationalStateChangeListener obj)
		{
			return default(HandleRef);
		}

		~GlobalOperationalStateChangeListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
