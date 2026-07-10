using System;

namespace FontSizeProfiles.BuildParts
{
	[Serializable]
	public class MonoBehaviourEnableSettings : ElementSettings
	{
		public bool isEnabled;

		public MonoBehaviourEnableSettings()
		{
		}

		public MonoBehaviourEnableSettings(string id, bool isEnabled)
		{
		}
	}
}
