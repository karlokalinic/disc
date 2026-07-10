using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalStatsAndAchievementsStoreListener : IStatsAndAchievementsStoreListener
	{
		private HandleRef swigCPtr;

		internal GlobalStatsAndAchievementsStoreListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalStatsAndAchievementsStoreListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalStatsAndAchievementsStoreListener obj)
		{
			return default(HandleRef);
		}

		~GlobalStatsAndAchievementsStoreListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
