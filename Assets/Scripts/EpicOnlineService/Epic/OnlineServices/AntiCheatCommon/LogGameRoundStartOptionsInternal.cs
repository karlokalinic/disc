using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct LogGameRoundStartOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_SessionIdentifier;

		private IntPtr m_LevelName;

		private IntPtr m_ModeName;

		private uint m_RoundTimeSeconds;

		public string SessionIdentifier
		{
			set
			{
			}
		}

		public string LevelName
		{
			set
			{
			}
		}

		public string ModeName
		{
			set
			{
			}
		}

		public uint RoundTimeSeconds
		{
			set
			{
			}
		}

		public void Set(LogGameRoundStartOptions other)
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
