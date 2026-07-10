using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class LeftStatsHealthBonusesPanelProfile : ViewProfile
	{
		public TextElementSettings statNumericalValues;

		public TextElementSettings statAbbreviation;

		public TextElementSettings healthMoraleLabel;

		public TextElementSettings healthMoraleValue;

		public TextElementSettings bonusesTitle;

		public TextElementSettings bonusesTextValues;

		public TextElementSettings buttonPrompts;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
