using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct AudioInputDeviceInfoInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private int m_DefaultDevice;

		private IntPtr m_DeviceId;

		private IntPtr m_DeviceName;

		public bool DefaultDevice
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string DeviceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DeviceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(AudioInputDeviceInfo other)
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
