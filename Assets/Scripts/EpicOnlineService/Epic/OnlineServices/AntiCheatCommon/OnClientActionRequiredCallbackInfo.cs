using System;

namespace Epic.OnlineServices.AntiCheatCommon
{
	public class OnClientActionRequiredCallbackInfo : ICallbackInfo, ISettable
	{
		public object ClientData { get; private set; }

		public IntPtr ClientHandle { get; private set; }

		public AntiCheatCommonClientAction ClientAction { get; private set; }

		public AntiCheatCommonClientActionReason ActionReasonCode { get; private set; }

		public string ActionReasonDetailsString { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnClientActionRequiredCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
