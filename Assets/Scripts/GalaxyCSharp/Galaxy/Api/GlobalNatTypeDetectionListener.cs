using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalNatTypeDetectionListener : INatTypeDetectionListener
	{
		private HandleRef swigCPtr;

		internal GlobalNatTypeDetectionListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalNatTypeDetectionListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalNatTypeDetectionListener obj)
		{
			return default(HandleRef);
		}

		~GlobalNatTypeDetectionListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
