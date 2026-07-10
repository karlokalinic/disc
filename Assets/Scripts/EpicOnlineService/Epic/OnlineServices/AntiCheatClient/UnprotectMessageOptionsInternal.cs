using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct UnprotectMessageOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_DataLengthBytes;

		private IntPtr m_Data;

		private uint m_OutBufferSizeBytes;

		public byte[] Data
		{
			set
			{
			}
		}

		public uint OutBufferSizeBytes
		{
			set
			{
			}
		}

		public void Set(UnprotectMessageOptions other)
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
