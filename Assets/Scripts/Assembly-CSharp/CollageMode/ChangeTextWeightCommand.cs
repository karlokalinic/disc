using System;
using TMPro;

namespace CollageMode
{
	public class ChangeTextWeightCommand : Command
	{
		private readonly Guid guid;

		private readonly FontWeight previousWeight;

		private readonly FontWeight newWeight;

		public ChangeTextWeightCommand(Guid guid, FontWeight previousWeight, FontWeight newWeight)
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
