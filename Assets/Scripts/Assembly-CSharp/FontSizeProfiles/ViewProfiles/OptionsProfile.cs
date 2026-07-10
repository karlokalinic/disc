using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class OptionsProfile : ViewProfile
	{
		public TextElementSettings optionsLabels;

		public TextElementSettings optionsItemsLabels;

		public TextElementSettings optionsLanguageHelp;

		public TextElementSettings optionsLanguageAnd;

		public RectElementHeightSettings optionElementHeight;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
