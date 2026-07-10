using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class InfoPanelProfile : ViewProfile
	{
		public TextElementSettings title;

		public TextElementSettings description;

		public TextElementSettings tipsText;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
