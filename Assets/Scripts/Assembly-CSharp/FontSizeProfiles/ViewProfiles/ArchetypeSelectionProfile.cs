using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class ArchetypeSelectionProfile : ViewProfile
	{
		public TextElementSettings archetypeSelection_Title;

		public AutoTextElementSettings archetypeSelection_Name;

		public AutoTextElementSettings archetypeSelection_Description;

		public TextElementSettings archetypeSelection_StatName;

		public TextElementSettings archetypeSelection_StatValue;

		public TextElementSettings archetypeSelection_SignatureText;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
