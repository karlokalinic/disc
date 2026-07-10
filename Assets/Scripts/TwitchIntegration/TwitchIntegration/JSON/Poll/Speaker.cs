using System;

namespace TwitchIntegration.JSON.Poll
{
	[Serializable]
	public class Speaker
	{
		public string name;

		public bool hasCheck;

		public Check check;

		public Speaker()
		{
		}

		public Speaker(string name, Check check)
		{
		}

		internal static Speaker GetExample()
		{
			return null;
		}
	}
}
