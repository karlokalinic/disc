using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.KWS
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct RequestPermissionsOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private uint m_PermissionKeyCount;

		private IntPtr m_PermissionKeys;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public string[] PermissionKeys
		{
			set
			{
			}
		}

		public void Set(RequestPermissionsOptions other)
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
