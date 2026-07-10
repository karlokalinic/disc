using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLeaderboardsRetrieveListener : ILeaderboardsRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalLeaderboardsRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLeaderboardsRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLeaderboardsRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLeaderboardsRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
