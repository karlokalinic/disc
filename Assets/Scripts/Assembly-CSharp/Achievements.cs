public static class Achievements
{
	public static bool _DEBUG;

	public static SocialPlatform Platform => default(SocialPlatform);

	public static void Initialize()
	{
	}

	public static void Destroy()
	{
	}

	public static bool Set(string ach)
	{
		return false;
	}

	public static bool Get(string ach)
	{
		return false;
	}

	public static bool Clear(string ach)
	{
		return false;
	}

	public static bool SetStat(string ach, float val)
	{
		return false;
	}

	public static bool SetStat(string ach, int val)
	{
		return false;
	}

	public static bool GetStat(string ach, out float val)
	{
		val = default(float);
		return false;
	}

	public static bool GetStat(string ach, out int val)
	{
		val = default(int);
		return false;
	}

	public static bool ResetAllStats(bool ach)
	{
		return false;
	}

	private static void LogWarningIfPlatformIsNone()
	{
	}
}
