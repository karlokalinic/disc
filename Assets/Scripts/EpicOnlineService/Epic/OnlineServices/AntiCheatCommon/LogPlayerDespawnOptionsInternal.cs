using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct LogPlayerDespawnOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_DespawnedPlayerHandle;

		public IntPtr DespawnedPlayerHandle
		{
			set
			{
			}
		}

		public void Set(LogPlayerDespawnOptions other)
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
