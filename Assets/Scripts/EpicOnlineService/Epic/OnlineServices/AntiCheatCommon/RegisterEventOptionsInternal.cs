using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct RegisterEventOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_EventId;

		private IntPtr m_EventName;

		private AntiCheatCommonEventType m_EventType;

		private uint m_ParamDefsCount;

		private IntPtr m_ParamDefs;

		public uint EventId
		{
			set
			{
			}
		}

		public string EventName
		{
			set
			{
			}
		}

		public AntiCheatCommonEventType EventType
		{
			set
			{
			}
		}

		public RegisterEventParamDef[] ParamDefs
		{
			set
			{
			}
		}

		public void Set(RegisterEventOptions other)
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
