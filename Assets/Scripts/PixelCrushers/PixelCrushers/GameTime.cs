namespace PixelCrushers
{
	public static class GameTime
	{
		private static GameTimeMode s_mode;

		private static float s_manualTime;

		private static float s_manualDeltaTime;

		private static bool s_manualPaused;

		public static GameTimeMode mode
		{
			get
			{
				return default(GameTimeMode);
			}
			set
			{
			}
		}

		public static float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float deltaTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float timeScale => 0f;

		public static bool isPaused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
