using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 12)]
	internal struct Vec3fInternal : ISettable, IDisposable
	{
		private float m_x;

		private float m_y;

		private float m_z;

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

		public void Set(Vec3f other)
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
