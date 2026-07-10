using System;

namespace Epic.OnlineServices.AntiCheatCommon
{
	public class LogEventParamPairParamValue : ISettable
	{
		private AntiCheatCommonEventParamType m_ParamValueType;

		private IntPtr? m_ClientHandle;

		private string m_String;

		private uint? m_UInt32;

		private int? m_Int32;

		private ulong? m_UInt64;

		private long? m_Int64;

		private Vec3f m_Vec3f;

		private Quat m_Quat;

		public AntiCheatCommonEventParamType ParamValueType
		{
			get
			{
				return default(AntiCheatCommonEventParamType);
			}
			private set
			{
			}
		}

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

		public static implicit operator LogEventParamPairParamValue(IntPtr value)
		{
			return null;
		}

		public static implicit operator LogEventParamPairParamValue(string value)
		{
			return null;
		}

		public static implicit operator LogEventParamPairParamValue(uint value)
		{
			return null;
		}

		public static implicit operator LogEventParamPairParamValue(int value)
		{
			return null;
		}

		public static implicit operator LogEventParamPairParamValue(ulong value)
		{
			return null;
		}

		public static implicit operator LogEventParamPairParamValue(long value)
		{
			return null;
		}

		public static implicit operator LogEventParamPairParamValue(Vec3f value)
		{
			return null;
		}

		public static implicit operator LogEventParamPairParamValue(Quat value)
		{
			return null;
		}

		internal void Set(LogEventParamPairParamValueInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
