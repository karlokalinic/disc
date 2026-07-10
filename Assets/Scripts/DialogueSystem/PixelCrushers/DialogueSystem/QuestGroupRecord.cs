using System;

namespace PixelCrushers.DialogueSystem
{
	public class QuestGroupRecord : IComparable
	{
		public string groupName;

		public string questTitle;

		public QuestGroupRecord()
		{
		}

		public QuestGroupRecord(string groupName, string questTitle)
		{
		}

		public int CompareTo(object obj)
		{
			return 0;
		}
	}
}
