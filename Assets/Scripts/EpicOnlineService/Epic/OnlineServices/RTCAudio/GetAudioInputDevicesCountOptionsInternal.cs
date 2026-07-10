using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
	internal struct GetAudioInputDevicesCountOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		public void Set(GetAudioInputDevicesCountOptions other)
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
