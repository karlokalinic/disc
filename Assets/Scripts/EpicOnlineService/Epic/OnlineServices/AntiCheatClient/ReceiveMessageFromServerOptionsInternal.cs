using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct ReceiveMessageFromServerOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_DataLengthBytes;

		private IntPtr m_Data;

		public byte[] Data
		{
			set
			{
			}
		}

		public void Set(ReceiveMessageFromServerOptions other)
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
