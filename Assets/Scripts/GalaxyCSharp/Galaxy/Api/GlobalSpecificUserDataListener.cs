using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalSpecificUserDataListener : ISpecificUserDataListener
	{
		private HandleRef swigCPtr;

		internal GlobalSpecificUserDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalSpecificUserDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalSpecificUserDataListener obj)
		{
			return default(HandleRef);
		}

		~GlobalSpecificUserDataListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
