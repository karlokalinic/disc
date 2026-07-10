namespace CollageMode
{
	public class CollageAnswerEntriesContainer : BaseCollageDialogueEntriesContainer
	{
		public class AnswerEntryData
		{
			public string Text;

			public CheckType CheckType;
		}

		protected override CollageDialogueEntryType EntryType => default(CollageDialogueEntryType);

		public void SetCheckType(int index, CheckType checkType)
		{
		}

		protected override void InvokeOnChanged()
		{
		}
	}
}
