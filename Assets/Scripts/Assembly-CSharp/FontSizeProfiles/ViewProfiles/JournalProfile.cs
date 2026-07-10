using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class JournalProfile : ViewProfile
	{
		public TextElementSettings screenTitle;

		public TextElementSettings taskMapTab;

		public TextElementSettings dayTitle;

		public TextElementSettings taskItem;

		public TextElementSettings activeDoneTab;

		public TextElementSettings taskTitle;

		public TextElementSettings taskState;

		public TextElementSettings taskDetails;

		public TextElementSettings officerProfile;

		public TextElementSettings characterName;

		public TextElementSettings characterRank;

		public TextElementSettings characterStats;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
