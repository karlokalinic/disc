using System;

namespace TwitchIntegration.JSON.UpdateGameData
{
	[Serializable]
	public class Step
	{
		public string name;

		public string description;

		public string filed_at;

		public bool completed;

		internal static Step[] GetArrayExample()
		{
			return null;
		}

		public bool Equals(Step obj)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
