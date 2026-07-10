using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct AddExternalIntegrityCatalogOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_PathToBinFile;

		public string PathToBinFile
		{
			set
			{
			}
		}

		public void Set(AddExternalIntegrityCatalogOptions other)
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
