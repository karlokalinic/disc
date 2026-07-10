using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 20)]
	internal struct LocalRTCOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private uint m_Flags;

		private int m_UseManualAudioInput;

		private int m_UseManualAudioOutput;

		private int m_LocalAudioDeviceInputStartsMuted;

		public uint Flags
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public bool UseManualAudioInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseManualAudioOutput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LocalAudioDeviceInputStartsMuted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Set(LocalRTCOptions other)
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
