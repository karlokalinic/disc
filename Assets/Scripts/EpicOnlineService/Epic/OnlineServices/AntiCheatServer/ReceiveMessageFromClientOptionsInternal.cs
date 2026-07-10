using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatServer
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct ReceiveMessageFromClientOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_ClientHandle;

		private uint m_DataLengthBytes;

		private IntPtr m_Data;

		public IntPtr ClientHandle
		{
			set
			{
			}
		}

		public byte[] Data
		{
			set
			{
			}
		}

		public void Set(ReceiveMessageFromClientOptions other)
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
