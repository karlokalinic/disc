using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct LogPlayerReviveOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_RevivedPlayerHandle;

		private IntPtr m_ReviverPlayerHandle;

		public IntPtr RevivedPlayerHandle
		{
			set
			{
			}
		}

		public IntPtr ReviverPlayerHandle
		{
			set
			{
			}
		}

		public void Set(LogPlayerReviveOptions other)
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
