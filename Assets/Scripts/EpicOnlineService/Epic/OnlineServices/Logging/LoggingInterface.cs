using System;

namespace Epic.OnlineServices.Logging
{
	public static class LoggingInterface
	{
		public static Result SetCallback(LogMessageFunc callback)
		{
			return default(Result);
		}

		public static Result SetLogLevel(LogCategory logCategory, LogLevel logLevel)
		{
			return default(Result);
		}

		internal static void LogMessageFuncInternalImplementation(IntPtr message)
		{
		}
	}
}
