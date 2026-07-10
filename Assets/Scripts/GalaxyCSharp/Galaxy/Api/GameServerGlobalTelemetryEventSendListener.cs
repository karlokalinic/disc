using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalTelemetryEventSendListener : ITelemetryEventSendListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalTelemetryEventSendListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalTelemetryEventSendListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalTelemetryEventSendListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalTelemetryEventSendListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
