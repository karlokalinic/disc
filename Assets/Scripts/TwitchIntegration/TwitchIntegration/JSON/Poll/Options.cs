using System;

namespace TwitchIntegration.JSON.Poll
{
	[Serializable]
	public class Options
	{
		public string label;

		public string type;

		public bool locked;

		public Options()
		{
		}

		public Options(string label, bool locked, bool isRedCheck, bool isWhiteCheck)
		{
		}

		private static string GetCheckToString(bool isRedCheck, bool isWhiteCheck)
		{
			return null;
		}

		internal static Options[] GetArrayExample()
		{
			return null;
		}
	}
}
