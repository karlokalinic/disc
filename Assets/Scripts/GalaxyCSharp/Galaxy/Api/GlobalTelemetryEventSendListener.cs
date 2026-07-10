using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalTelemetryEventSendListener : ITelemetryEventSendListener
	{
		private HandleRef swigCPtr;

		internal GlobalTelemetryEventSendListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalTelemetryEventSendListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalTelemetryEventSendListener obj)
		{
			return default(HandleRef);
		}

		~GlobalTelemetryEventSendListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}
