using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct DeleteSnapshotOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public void Set(DeleteSnapshotOptions other)
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
