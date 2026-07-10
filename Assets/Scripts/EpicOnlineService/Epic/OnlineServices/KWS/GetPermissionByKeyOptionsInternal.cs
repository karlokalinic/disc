using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.KWS
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct GetPermissionByKeyOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private IntPtr m_Key;

		public ProductUserId LocalUserId
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

		public void Set(GetPermissionByKeyOptions other)
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
