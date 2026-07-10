using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.KWS
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct CreateUserOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		private IntPtr m_DateOfBirth;

		private IntPtr m_ParentEmail;

		public ProductUserId LocalUserId
		{
			set
			{
			}
		}

		public string DateOfBirth
		{
			set
			{
			}
		}

		public string ParentEmail
		{
			set
			{
			}
		}

		public void Set(CreateUserOptions other)
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
