using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct SubmitSnapshotCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private uint m_SnapshotId;

		private IntPtr m_ClientData;

		public Result ResultCode => default(Result);

		public uint SnapshotId => 0u;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;
	}
}
