public static class GameStatsManager
{
	private const string ALCOHOL_USAGE_KEY = "alcohol_usage";

	private const string CIGARETTES_USAGE_KEY = "cigarettes_usage";

	private const string PYRHOLIDON_USAGE_KEY = "pyrolidon_usage";

	private const string SPEED_USAGE_KEY = "speed_usage";

	private const string TARE_SOLD_KEY = "tare_sold_key";

	private const string STEPS_TRAVELLED_AMOUNT_KEY = "steps_travelled_amount";

	private const string HARDCORE_PLAYTHROUGH_COMPLETED = "hardcore_playthrough_completed";

	private static int alcoholUsage;

	private static int cigarettesUsage;

	private static int pyrholidonUsage;

	private static int speedUsage;

	private static int tareSold;

	private static int stepsTravelledAmount;

	private static bool hardcorePlaythroughCompleted;

	public static int AlcoholUsage
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int CigarettesUsage
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int PyrholidonUsage
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int SpeedUsage
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TareSold
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int StepsTravelledAmount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool HardcorePlaythroughCompleted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	static GameStatsManager()
	{
	}

	public static void SaveGameStats(bool save = true, bool immediateSave = false, int timeout = 0)
	{
	}

	public static void SubstanceUsed(ItemGroup group)
	{
	}

	private static int GetIntOrDefaultStat(string key)
	{
		return 0;
	}

	private static bool GetBoolOrDefault(string key)
	{
		return false;
	}

	private static void SetInt(string key, int value, bool save = false)
	{
	}

	private static void SetBool(string key, bool value, bool save = true)
	{
	}
}
