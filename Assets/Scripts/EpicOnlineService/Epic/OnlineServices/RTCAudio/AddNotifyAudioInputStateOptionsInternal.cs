using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct AddNotifyAudioInputStateOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private IntPtr m_RoomName;

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

		public void Set(AddNotifyAudioInputStateOptions other)
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
