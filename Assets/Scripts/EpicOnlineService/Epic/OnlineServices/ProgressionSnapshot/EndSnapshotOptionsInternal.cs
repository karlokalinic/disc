using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct EndSnapshotOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_SnapshotId;

		public uint SnapshotId
		{
			set
			{
			}
		}

		public void Set(EndSnapshotOptions other)
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
