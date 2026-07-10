using System;

namespace TwitchIntegration.JSON.UpdateGameData
{
	[Serializable]
	public class Task
	{
		public string title;

		public string filed_at;

		public string description;

		public bool completed;

		public Step[] steps;

		internal static Task[] GetArrayExample()
		{
			return null;
		}

		internal static Task GetExample()
		{
			return null;
		}

		public bool Equals(Task obj)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
