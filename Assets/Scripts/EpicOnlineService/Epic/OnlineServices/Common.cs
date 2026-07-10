namespace Epic.OnlineServices
{
	public static class Common
	{
		public const ulong InvalidNotificationid = 0uL;

		public const int PagequeryApiLatest = 1;

		public const int PagequeryMaxcountDefault = 10;

		public const int PagequeryMaxcountMaximum = 100;

		public const int PaginationApiLatest = 1;

		public static bool IsOperationComplete(Result result)
		{
			return false;
		}

		public static string ToString(Result result)
		{
			return null;
		}

		public static Result ToString(byte[] byteArray, out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public static string ToString(byte[] byteArray)
		{
			return null;
		}
	}
}
