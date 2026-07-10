namespace CollageMode
{
	public class ChangeCheckTypeCommand : Command
	{
		private readonly int index;

		private readonly CheckType previousCheckType;

		private readonly CheckType newCheckType;

		public ChangeCheckTypeCommand(int index, CheckType previousCheckType, CheckType newCheckType)
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
