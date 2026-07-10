using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLeaderboardEntriesRetrieveListener : ILeaderboardEntriesRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalLeaderboardEntriesRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLeaderboardEntriesRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLeaderboardEntriesRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLeaderboardEntriesRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
