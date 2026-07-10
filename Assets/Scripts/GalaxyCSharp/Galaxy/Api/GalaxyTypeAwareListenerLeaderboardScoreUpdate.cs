using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GalaxyTypeAwareListenerLeaderboardScoreUpdate : IGalaxyListener
	{
		private HandleRef swigCPtr;

		internal GalaxyTypeAwareListenerLeaderboardScoreUpdate(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GalaxyTypeAwareListenerLeaderboardScoreUpdate()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GalaxyTypeAwareListenerLeaderboardScoreUpdate obj)
		{
			return default(HandleRef);
		}

		~GalaxyTypeAwareListenerLeaderboardScoreUpdate()
		{
		}

		public override void Dispose()
		{
		}

		public static ListenerType GetListenerType()
		{
			return default(ListenerType);
		}
	}
}
