public static class GameModePersister
{
	public class GameModeState
	{
		public GameModeController.GameMode gameMode;

		public bool wasSwitched;
	}

	public static GameModeState Serialize()
	{
		return null;
	}

	public static void Deserialize(GameModeState state)
	{
	}
}
