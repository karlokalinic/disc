using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct SetRoomSettingOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private IntPtr m_RoomName;

		private IntPtr m_SettingName;

		private IntPtr m_SettingValue;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public string RoomName
		{
			set
			{
			}
		}

		public string SettingName
		{
			set
			{
			}
		}

		public string SettingValue
		{
			set
			{
			}
		}

		public void Set(SetRoomSettingOptions other)
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
