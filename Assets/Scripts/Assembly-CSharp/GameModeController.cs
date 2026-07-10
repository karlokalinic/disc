using UnityEngine;

public class GameModeController : MonoBehaviour
{
	public enum GameMode
	{
		NORMAL = 0,
		HARDCORE = 1
	}

	public delegate void GameModeEvent(GameMode mode);

	[SerializeField]
	private GameModeData normalMode;

	[SerializeField]
	private GameModeData hardcoreMode;

	private const string SINGLETON_MISSING = "There is no GameModeController in game (there should be one in the init scene)! I can't access any game mode value";

	private const string GAME_MODE_KEY = "GameMode";

	private static GameModeController singleton;

	private static bool wasDestroyed;

	public GameModeEvent OnGameModeChanged;

	public GameModeData currentModeData { get; private set; }

	public GameMode currentMode { get; private set; }

	public bool wasGameModeSwitched { get; set; }

	public static GameModeController Singleton => null;

	public static int WhiteCheckModifier => 0;

	public static float HealingItemCostMultiplier => 0f;

	public static float DrugItemCostMultiplier => 0f;

	public static float ContainerMoneyMultiplayer => 0f;

	public static int DrugBaseChargesAmount => 0;

	public static int ExpMinorRewardBonus => 0;

	public static int ExpStandardRewardBonus => 0;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static bool IsHardcoreOn()
	{
		return false;
	}

	public static bool IsHardcorePlaythrough()
	{
		return false;
	}

	private void ChangeGameMode(GameMode gameMode)
	{
	}

	public static void HardcoreModeOn(bool value)
	{
	}
}
