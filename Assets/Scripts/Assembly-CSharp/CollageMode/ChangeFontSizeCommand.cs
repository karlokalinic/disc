using System;

namespace CollageMode
{
	public class ChangeFontSizeCommand : Command
	{
		private readonly Guid guid;

		private readonly float previousFontSize;

		private readonly float newFontSize;

		public ChangeFontSizeCommand(Guid guid, float previousFontSize, float newFontSize)
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
