using System.Collections.Generic;
using Sunshine.Metric;

public static class FailedWhiteChecksPersister
{
	public class FailedWhiteChecksHolder
	{
		public Dictionary<string, Dictionary<string, List<WhiteCheck>>> ReopenedWhiteChecksByActorName;

		public Dictionary<string, WhiteCheck> WhiteCheckCache;

		public Dictionary<string, WhiteCheck> SeenWhiteCheckCache;

		public Dictionary<SkillType, List<string>> ChecksBySkill;

		public Dictionary<string, List<string>> ChecksByVariable;
	}

	public static FailedWhiteChecksHolder Serialize()
	{
		return null;
	}

	public static void Deserialize(FailedWhiteChecksHolder holder)
	{
	}
}
