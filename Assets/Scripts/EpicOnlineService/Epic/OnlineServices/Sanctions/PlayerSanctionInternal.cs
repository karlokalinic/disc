using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sanctions
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct PlayerSanctionInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private long m_TimePlaced;

		private IntPtr m_Action;

		private long m_TimeExpires;

		private IntPtr m_ReferenceId;

		public long TimePlaced
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string Action
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long TimeExpires
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string ReferenceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(PlayerSanction other)
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
