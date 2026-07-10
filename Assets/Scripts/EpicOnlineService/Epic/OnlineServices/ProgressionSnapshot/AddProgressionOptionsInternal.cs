using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct AddProgressionOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_SnapshotId;

		private IntPtr m_Key;

		private IntPtr m_Value;

		public uint SnapshotId
		{
			set
			{
			}
		}

		public string Key
		{
			set
			{
			}
		}

		public string Value
		{
			set
			{
			}
		}

		public void Set(AddProgressionOptions other)
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
