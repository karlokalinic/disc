using System;

namespace CollageMode
{
	public class RemoveCollageElementCommand : Command
	{
		private readonly Guid guid;

		private CollageElement.InitData initData;

		public RemoveCollageElementCommand(Guid guid)
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
