namespace CollageMode
{
	public class ChangeFrameCommand : Command
	{
		private readonly string previousFrame;

		private readonly string newFrame;

		public ChangeFrameCommand(string previousFrame, string newFrame)
		{
		}

		public override void Execute(CollageMode collageMode)
		{
		}

		public override void Preview(CollageMode collageMode)
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
