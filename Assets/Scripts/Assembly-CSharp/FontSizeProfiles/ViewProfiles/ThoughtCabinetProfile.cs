using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class ThoughtCabinetProfile : ViewProfile
	{
		public TextElementSettings menuTitle;

		public TextElementSettings sortThoughts;

		public TextElementSettings sortType;

		public TextElementSettings thoughtListItem;

		public AutoTextElementSettings thoughtListItemAutoSize;

		public TextElementSettings thoughtTitle;

		public AutoTextElementSettings autoThoughtBonus;

		public TextElementSettings problemSolution;

		public TextElementSettings description;

		public TextElementSettings experiencePoints;

		public TextElementSettings skillPointsLabel;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
