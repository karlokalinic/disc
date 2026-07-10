using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class MainMenuProfile : ViewProfile
	{
		public AutoTextElementSettings mainMenuButtons;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
