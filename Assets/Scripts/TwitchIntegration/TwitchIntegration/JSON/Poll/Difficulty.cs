using System;

namespace TwitchIntegration.JSON.Poll
{
	[Serializable]
	public class Difficulty
	{
		public string level;

		public bool success;

		public Difficulty()
		{
		}

		public Difficulty(string level, bool success)
		{
		}

		internal static Difficulty GetExample()
		{
			return null;
		}
	}
}
