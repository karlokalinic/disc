namespace CollageMode
{
	public class ChangeFilterCommand : Command
	{
		private readonly string previousFilter;

		private readonly float previousIntensity;

		private readonly string newFilter;

		private readonly float newIntensity;

		public ChangeFilterCommand(string newFilter, float newIntensity)
		{
		}

		public override void Execute(CollageMode collageMode)
		{
		}

		public override void Preview(CollageMode collageMode)
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
