namespace CollageMode
{
	public class ChangeContinueTypeCommand : Command
	{
		private readonly ContinueType previousValue;

		private readonly ContinueType newValue;

		public ChangeContinueTypeCommand(ContinueType previousValue, ContinueType newValue)
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
