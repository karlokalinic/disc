using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.CustomInvites
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct SetCustomInviteOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private IntPtr m_Payload;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public string Payload
		{
			set
			{
			}
		}

		public void Set(SetCustomInviteOptions other)
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
