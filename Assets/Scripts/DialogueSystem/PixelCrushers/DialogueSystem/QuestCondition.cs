using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class QuestCondition
	{
		public string questName;

		[QuestState]
		public QuestState questState;

		public bool IsTrue => false;
	}
}
