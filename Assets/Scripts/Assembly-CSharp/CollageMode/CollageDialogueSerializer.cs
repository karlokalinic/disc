using System.Collections.Generic;

namespace CollageMode
{
	public class CollageDialogueSerializer : ISerializableManager
	{
		public class AnswerEntryData
		{
			public string Text;

			public CheckType CheckType;
		}

		public class DialogueSaveData : SerializableData
		{
			public List<string> DialogueEntries;

			public List<AnswerEntryData> AnswerEntries;

			public ContinueType ContinueType;

			public int ContinueButtonIndex;
		}

		private CollageDialogue dialogue => null;

		public string SerializedCategoryName => null;

		public SerializableData Save()
		{
			return null;
		}

		private List<string> SaveDialogueEntries()
		{
			return null;
		}

		private List<AnswerEntryData> SaveAnswerEntries()
		{
			return null;
		}

		public void Load(SerializableData data)
		{
		}

		private void LoadDialogueEntries(List<string> data)
		{
		}

		private void LoadAnswerEntries(List<AnswerEntryData> data)
		{
		}
	}
}
