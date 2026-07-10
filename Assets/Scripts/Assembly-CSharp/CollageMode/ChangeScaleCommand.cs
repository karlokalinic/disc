using System;

namespace CollageMode
{
	public class ChangeScaleCommand : Command
	{
		private readonly Guid guid;

		private readonly float previousScale;

		private readonly float newScale;

		public ChangeScaleCommand(Guid guid, float previousScale, float newScale)
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
