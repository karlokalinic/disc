using System;

namespace Epic.OnlineServices.AntiCheatCommon
{
	public class OnMessageToClientCallbackInfo : ICallbackInfo, ISettable
	{
		public object ClientData { get; private set; }

		public IntPtr ClientHandle { get; private set; }

		public byte[] MessageData { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnMessageToClientCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
