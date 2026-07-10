using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLeaderboardRetrieveListener : ILeaderboardRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalLeaderboardRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLeaderboardRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLeaderboardRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLeaderboardRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
