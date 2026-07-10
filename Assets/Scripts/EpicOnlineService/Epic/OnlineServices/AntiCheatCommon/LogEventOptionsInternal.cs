using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct LogEventOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_ClientHandle;

		private uint m_EventId;

		private uint m_ParamsCount;

		private IntPtr m_Params;

		public IntPtr ClientHandle
		{
			set
			{
			}
		}

		public uint EventId
		{
			set
			{
			}
		}

		public LogEventParamPair[] Params
		{
			set
			{
			}
		}

		public void Set(LogEventOptions other)
		{
		}

		public void Set(object other)
		{
		}

		public void Dispose()
		{
		}
	}
}
