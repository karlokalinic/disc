using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct LogEventParamPairInternal : ISettable, IDisposable
	{
		private LogEventParamPairParamValueInternal m_ParamValue;

		public LogEventParamPairParamValue ParamValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(LogEventParamPair other)
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
