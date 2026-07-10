using System;

namespace Epic.OnlineServices.Reports
{
	public sealed class ReportsInterface : Handle
	{
		public const int ReportcontextMaxLength = 4096;

		public const int ReportmessageMaxLength = 512;

		public const int SendplayerbehaviorreportApiLatest = 2;

		public ReportsInterface()
		{
		}

		public ReportsInterface(IntPtr innerHandle)
		{
		}

		public void SendPlayerBehaviorReport(SendPlayerBehaviorReportOptions options, object clientData, OnSendPlayerBehaviorReportCompleteCallback completionDelegate)
		{
		}

		internal static void OnSendPlayerBehaviorReportCompleteCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
