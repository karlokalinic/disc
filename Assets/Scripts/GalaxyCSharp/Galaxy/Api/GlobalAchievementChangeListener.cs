using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalAchievementChangeListener : IAchievementChangeListener
	{
		private HandleRef swigCPtr;

		internal GlobalAchievementChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalAchievementChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalAchievementChangeListener obj)
		{
			return default(HandleRef);
		}

		~GlobalAchievementChangeListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
