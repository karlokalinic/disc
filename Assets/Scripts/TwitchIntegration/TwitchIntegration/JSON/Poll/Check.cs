using System;

namespace TwitchIntegration.JSON.Poll
{
	[Serializable]
	public class Check
	{
		public string checkType;

		public string skillType;

		public string stat;

		public Difficulty difficulty;

		internal static Check Empty => null;

		public Check()
		{
		}

		public Check(string checkType, string skillType, string stat, string difficultyLevel, bool success)
		{
		}

		internal static Check GetExample()
		{
			return null;
		}
	}
}
