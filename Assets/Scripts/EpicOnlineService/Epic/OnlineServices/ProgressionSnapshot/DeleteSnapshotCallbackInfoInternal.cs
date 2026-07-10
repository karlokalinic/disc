using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct DeleteSnapshotCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private IntPtr m_LocalUserId;

		private IntPtr m_ClientData;

		public Result ResultCode => default(Result);

		public ProductUserId LocalUserId => null;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;
	}
}
