namespace CollageMode
{
	public class ChangeDialogueIsOpenCommand : Command
	{
		private readonly bool isOpen;

		public ChangeDialogueIsOpenCommand(bool isOpen)
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
