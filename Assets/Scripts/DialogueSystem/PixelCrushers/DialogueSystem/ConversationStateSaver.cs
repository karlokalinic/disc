using System;
using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationStateSaver : Saver
	{
		[Serializable]
		public class Data
		{
			public int conversationID;

			public int entryID;

			public string actorName;

			public string conversantName;

			public List<string> actorGOs;

			public List<SubtitlePanelNumber> actorGOPanels;

			public List<int> actorIDs;

			public List<SubtitlePanelNumber> actorIDPanels;
		}

		public override string key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string s)
		{
		}
	}
}
