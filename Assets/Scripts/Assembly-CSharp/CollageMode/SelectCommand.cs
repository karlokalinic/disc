using System;

namespace CollageMode
{
	public class SelectCommand : Command
	{
		private readonly Guid newSelectedGuid;

		private readonly Guid previousSelectedGuid;

		public SelectCommand(Guid newSelectedGuid)
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
