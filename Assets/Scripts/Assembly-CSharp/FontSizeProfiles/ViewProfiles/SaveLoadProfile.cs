using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class SaveLoadProfile : ViewProfile
	{
		public TextElementSettings mainMenuButtons;

		public TextElementSettings dateHourText;

		public RectElementHorizontalSettings dayRect;

		public RectElementHorizontalSettings hourRect;

		public RectElementHorizontalSettings saveName;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
