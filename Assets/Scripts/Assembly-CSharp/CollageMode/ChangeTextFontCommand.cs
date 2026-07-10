using System;

namespace CollageMode
{
	public class ChangeTextFontCommand : Command
	{
		private readonly Guid guid;

		private readonly string previousFont;

		private readonly string newFont;

		public ChangeTextFontCommand(Guid guid, string previousFont, string newFont)
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
