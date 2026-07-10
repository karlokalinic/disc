using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class NewspaperEndingProfile : ViewProfile
	{
		public AutoTextElementSettings headline;

		public TextElementSettings description;

		public RectElementSettings paragraph;

		public MonoBehaviourEnableSettings backgroundCoverEnabled;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
