namespace CollageMode
{
	public class ChangeWeatherCommand : Command
	{
		private readonly string previousWeather;

		private readonly string newWeather;

		public ChangeWeatherCommand(string previousWeather, string newWeather)
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
