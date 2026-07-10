using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GalaxyTypeAwareListenerLeaderboardsRetrieve : IGalaxyListener
	{
		private HandleRef swigCPtr;

		internal GalaxyTypeAwareListenerLeaderboardsRetrieve(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GalaxyTypeAwareListenerLeaderboardsRetrieve()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GalaxyTypeAwareListenerLeaderboardsRetrieve obj)
		{
			return default(HandleRef);
		}

		~GalaxyTypeAwareListenerLeaderboardsRetrieve()
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
