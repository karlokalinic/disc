public class TequilaStates
{
	public static bool obscured;

	public static bool fascist;

	public static bool expressionStopped;

	private static bool _shaved;

	private static bool _bodysuit;

	public static bool restoreHangover;

	private static readonly int wakingUp;

	private static readonly int startWakingUp;

	private static readonly int normalWalkCycle;

	public static bool hasHangover { get; set; }

	public static bool shaved
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool wearingBodysuit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool shavedAndExpressionStopped => false;

	public static bool headIKEnabled { get; private set; }

	public static void ResetTequilaState()
	{
	}

	public static void StartHangover()
	{
	}

	public static void RestoreHangoverState()
	{
	}

	public static void RemoveHangover()
	{
	}

	public static void ToggleTequilaHeadIK(bool headIKOn)
	{
	}

	private static void ResetController()
	{
	}

	private static void RefreshTequilaMaterial()
	{
	}
}
