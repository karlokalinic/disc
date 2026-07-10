using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.KWS
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct PermissionStatusInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_Name;

		private KWSPermissionStatus m_Status;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public KWSPermissionStatus Status
		{
			get
			{
				return default(KWSPermissionStatus);
			}
			set
			{
			}
		}

		public void Set(PermissionStatus other)
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
