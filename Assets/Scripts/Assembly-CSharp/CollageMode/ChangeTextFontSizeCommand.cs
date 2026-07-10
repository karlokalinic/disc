using System;

namespace CollageMode
{
	public class ChangeTextFontSizeCommand : Command
	{
		private readonly Guid guid;

		private readonly float previousFontSize;

		private readonly float newFontSize;

		public ChangeTextFontSizeCommand(Guid guid, float previousFontSize, float newFontSize)
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
