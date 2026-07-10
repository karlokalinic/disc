using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class CharsheetProfile : ViewProfile
	{
		public TextElementSettings attributeValue;

		public TextElementSettings attributeName;

		public TextElementSettings skillValue;

		public TextElementSettings menuTitle;

		public TextElementSettings overviewInfo;

		public AutoTextElementSettings highlightedSkillName;

		public AutoTextElementSettings highlightedSkillDescription;

		public TextElementSettings highlightedSkillModifiers;

		public TextElementSettings totalSkillPointsLabel;

		public TextElementSettings totalSkillPointsValue;

		public TextElementSettings experience;

		public TextElementSettings skillPoints;

		public TextElementSettings skillInfo;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
