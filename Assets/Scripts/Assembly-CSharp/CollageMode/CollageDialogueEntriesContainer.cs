namespace CollageMode
{
	public class CollageDialogueEntriesContainer : BaseCollageDialogueEntriesContainer
	{
		protected override CollageDialogueEntryType EntryType => default(CollageDialogueEntryType);

		public Operation GetLastCharacterOperation()
		{
			return null;
		}

		private string GetCharacterName(string text)
		{
			return null;
		}
	}
}
