using Voidforge;

internal class OrbitStateSelector : SingletonComponent<OrbitStateSelector>
{
	public static OrbitState currentState;

	private static float hoverTime;

	private static float tabState;

	private static bool detectiveMode;

	private static bool orbMouseover;

	private static bool circleMouseover;

	private static bool delayDrop;

	private static bool pendingOrb;

	private static bool disableOrbits;

	private static bool toggledHighlight;

	private Timer timer;

	public static bool DisableOrbits
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool DetectiveMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool OrbMouseover
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool CircleMouseover
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool HasPendingOrb
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DelayDrop
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void SetDirty()
	{
	}

	public static void ChangeState(OrbitState newState)
	{
	}

	public static OrbitState NowWhat()
	{
		return default(OrbitState);
	}

	public void CT()
	{
	}

	public static void CheckTab()
	{
	}

	public static void UpdateState(float aniTime, float target, ref float state)
	{
	}
}
