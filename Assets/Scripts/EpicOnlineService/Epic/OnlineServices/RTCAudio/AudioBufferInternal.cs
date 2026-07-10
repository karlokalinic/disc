using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct AudioBufferInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_Frames;

		private uint m_FramesCount;

		private uint m_SampleRate;

		private uint m_Channels;

		public short[] Frames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint SampleRate
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint Channels
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public void Set(AudioBuffer other)
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
