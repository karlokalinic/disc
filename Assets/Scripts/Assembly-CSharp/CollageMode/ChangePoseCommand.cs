using System;

namespace CollageMode
{
	public class ChangePoseCommand : Command
	{
		private readonly Guid guid;

		private readonly string previousPose;

		private readonly string newPose;

		public ChangePoseCommand(CollageCharacter character, string newPose)
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
