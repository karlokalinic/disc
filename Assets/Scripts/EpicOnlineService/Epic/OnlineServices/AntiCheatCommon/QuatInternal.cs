using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct QuatInternal : ISettable, IDisposable
	{
		private float m_w;

		private float m_x;

		private float m_y;

		private float m_z;

		public float w
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float x
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float z
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void Set(Quat other)
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
