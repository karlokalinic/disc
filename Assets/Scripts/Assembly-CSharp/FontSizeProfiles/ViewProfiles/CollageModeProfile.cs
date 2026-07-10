using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class CollageModeProfile : ViewProfile
	{
		public TextElementSettings subDrawerSelector;

		public AutoTextElementSettings title;

		public TextElementSettings button;

		public TextElementSettings tooltip;

		public TextElementSettings popup;

		public TextElementSettings largeButton;

		public AutoTextElementSettings dialogueAutofill;

		public TextElementSettings screenshotPopup;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
