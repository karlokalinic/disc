using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.CustomInvites
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct FinalizeInviteOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_TargetUserId;

		private IntPtr m_LocalUserId;

		private IntPtr m_CustomInviteId;

		private Result m_ProcessingResult;

		public ProductUserId TargetUserId
		{
			set
			{
			}
		}

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public string CustomInviteId
		{
			set
			{
			}
		}

		public Result ProcessingResult
		{
			set
			{
			}
		}

		public void Set(FinalizeInviteOptions other)
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
