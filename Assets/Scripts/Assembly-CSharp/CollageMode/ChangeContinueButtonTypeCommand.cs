namespace CollageMode
{
	public class ChangeContinueButtonTypeCommand : Command
	{
		private readonly int previousContinueButtonIndex;

		private readonly int newContinueButtonIndex;

		public ChangeContinueButtonTypeCommand(int previousContinueButtonIndex, int newContinueButtonIndex)
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
