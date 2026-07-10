using System;

namespace CollageMode
{
	public class ChangeTextCommand : Command
	{
		private readonly Guid guid;

		private readonly string newText;

		private readonly string previousText;

		public ChangeTextCommand(Guid guid, string previousText, string newText)
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
