using System;

namespace TwitchIntegration.JSON.UpdateGameData
{
	[Serializable]
	public class UpdateGameData
	{
		public Stats stats;

		public Skill[] skills;

		public Task[] tasks;

		public static UpdateGameData GetExample()
		{
			return null;
		}

		public bool Equals(UpdateGameData objGameData)
		{
			return false;
		}

		public bool SkillEquals(Skill[] objSkills)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
