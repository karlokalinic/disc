using System;
using System.Runtime.CompilerServices;

namespace InControl
{
	public class Logger
	{
		public static event Action<LogMessage> OnLogMessage
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void LogInfo(string text)
		{
		}

		public static void LogWarning(string text)
		{
		}

		public static void LogError(string text)
		{
		}
	}
}
