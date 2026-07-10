using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class MapProfile : ViewProfile
	{
		public AutoTextElementSettings checkTitle;

		public TextElementSettings checkDifficulty;

		public AutoTextElementSettings checkTutorial;

		public TextElementSettings characterName;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
