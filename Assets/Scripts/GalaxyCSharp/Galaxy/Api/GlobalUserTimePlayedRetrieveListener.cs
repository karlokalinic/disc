using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalUserTimePlayedRetrieveListener : IUserTimePlayedRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalUserTimePlayedRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalUserTimePlayedRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalUserTimePlayedRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalUserTimePlayedRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
