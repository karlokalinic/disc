using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.KWS
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
	internal struct QueryAgeGateOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		public void Set(QueryAgeGateOptions other)
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
