using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalLeaderboardScoreUpdateListener : ILeaderboardScoreUpdateListener
	{
		private HandleRef swigCPtr;

		internal GlobalLeaderboardScoreUpdateListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalLeaderboardScoreUpdateListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalLeaderboardScoreUpdateListener obj)
		{
			return default(HandleRef);
		}

		~GlobalLeaderboardScoreUpdateListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
