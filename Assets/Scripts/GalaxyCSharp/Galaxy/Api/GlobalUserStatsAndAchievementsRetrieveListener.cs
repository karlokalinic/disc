using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalUserStatsAndAchievementsRetrieveListener : IUserStatsAndAchievementsRetrieveListener
	{
		private HandleRef swigCPtr;

		internal GlobalUserStatsAndAchievementsRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalUserStatsAndAchievementsRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalUserStatsAndAchievementsRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalUserStatsAndAchievementsRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
