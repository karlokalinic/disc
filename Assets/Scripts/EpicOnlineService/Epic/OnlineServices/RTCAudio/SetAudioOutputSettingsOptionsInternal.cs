using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct SetAudioOutputSettingsOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private IntPtr m_DeviceId;

		private float m_Volume;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public string DeviceId
		{
			set
			{
			}
		}

		public float Volume
		{
			set
			{
			}
		}

		public void Set(SetAudioOutputSettingsOptions other)
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
