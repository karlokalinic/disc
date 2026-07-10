using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 24)]
	internal struct LogEventParamPairParamValueInternal : ISettable, IDisposable
	{
		[FieldOffset(0)]
		private AntiCheatCommonEventParamType m_ParamValueType;

		[FieldOffset(8)]
		private IntPtr m_ClientHandle;

		[FieldOffset(8)]
		private IntPtr m_String;

		[FieldOffset(8)]
		private uint m_UInt32;

		[FieldOffset(8)]
		private int m_Int32;

		[FieldOffset(8)]
		private ulong m_UInt64;

		[FieldOffset(8)]
		private long m_Int64;

		[FieldOffset(8)]
		private Vec3fInternal m_Vec3f;

		[FieldOffset(8)]
		private QuatInternal m_Quat;

		public IntPtr? ClientHandle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string String
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint? UInt32
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int? Int32
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ulong? UInt64
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long? Int64
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vec3f Vec3f
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Quat Quat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(LogEventParamPairParamValue other)
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
