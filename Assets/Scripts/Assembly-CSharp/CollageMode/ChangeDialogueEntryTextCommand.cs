namespace CollageMode
{
	public class ChangeDialogueEntryTextCommand : Command
	{
		private readonly CollageDialogueEntryType entryType;

		private readonly int index;

		private readonly string previousText;

		private readonly string newText;

		public ChangeDialogueEntryTextCommand(CollageDialogueEntryType entryType, int index, string previousText, string newText)
		{
		}

		public override void Execute(CollageMode collageMode)
		{
		}

		public override void Undo(CollageMode collageMode)
		{
		}

		public override bool Validate(CollageMode collageMode)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
