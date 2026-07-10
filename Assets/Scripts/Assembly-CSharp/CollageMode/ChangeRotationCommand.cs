using System;

namespace CollageMode
{
	public class ChangeRotationCommand : Command
	{
		private readonly Guid guid;

		private readonly float previousRotation;

		private readonly float newRotation;

		public ChangeRotationCommand(Guid guid, float previousRotation, float newRotation)
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
