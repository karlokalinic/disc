using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Reports
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 48)]
	internal struct SendPlayerBehaviorReportOptionsInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_ReporterUserId;

		private IntPtr m_ReportedUserId;

		private PlayerReportsCategory m_Category;

		private IntPtr m_Message;

		private IntPtr m_Context;

		public ProductUserId ReporterUserId
		{
			set
			{
			}
		}

		public ProductUserId ReportedUserId
		{
			set
			{
			}
		}

		public PlayerReportsCategory Category
		{
			set
			{
			}
		}

		public string Message
		{
			set
			{
			}
		}

		public string Context
		{
			set
			{
			}
		}

		public void Set(SendPlayerBehaviorReportOptions other)
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
