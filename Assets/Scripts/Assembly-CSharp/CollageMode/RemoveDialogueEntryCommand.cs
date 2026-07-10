namespace CollageMode
{
	public class RemoveDialogueEntryCommand : Command
	{
		private readonly CollageDialogueEntryType entryType;

		private readonly int index;

		public RemoveDialogueEntryCommand(CollageDialogueEntryType entryType, int index)
		{
		}

		public override void Execute(CollageMode collageMode)
		{
		}

		public override void Undo(CollageMode collageMode)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
