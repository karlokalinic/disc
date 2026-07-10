using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct SetSettingOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_SettingName;

		private IntPtr m_SettingValue;

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

		public void Set(SetSettingOptions other)
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
