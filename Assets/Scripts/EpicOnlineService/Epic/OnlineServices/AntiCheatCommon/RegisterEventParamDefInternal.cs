using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct RegisterEventParamDefInternal : ISettable, IDisposable
	{
		private IntPtr m_ParamName;

		private AntiCheatCommonEventParamType m_ParamType;

		public string ParamName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AntiCheatCommonEventParamType ParamType
		{
			get
			{
				return default(AntiCheatCommonEventParamType);
			}
			set
			{
			}
		}

		public void Set(RegisterEventParamDef other)
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
