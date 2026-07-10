using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class ThoughtSplashScreenProfile : ViewProfile
	{
		public TextElementSettings screenTitle;

		public AutoTextElementSettings thoughtTitle;

		public TextElementSettings description;

		public TextElementSettings tabs;

		public TextElementSettings stats;

		public TextElementSettings button;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
