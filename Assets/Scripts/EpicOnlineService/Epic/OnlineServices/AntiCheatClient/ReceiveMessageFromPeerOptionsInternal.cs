using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct ReceiveMessageFromPeerOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_PeerHandle;

		private uint m_DataLengthBytes;

		private IntPtr m_Data;

		public IntPtr PeerHandle
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

		public void Set(ReceiveMessageFromPeerOptions other)
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
