using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class ControllerHelpMenuProfile : ViewProfile
	{
		public TextElementSettings controlerLabels;

		public TextElementSettings controlerStadiaDisclaimer;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
