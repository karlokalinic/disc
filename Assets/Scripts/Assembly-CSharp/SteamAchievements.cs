using UnityEngine;

public class SteamAchievements : MonoBehaviour
{
	protected object m_GameOverlayActivated;

	protected object m_UserStatsReceived;

	protected object m_UserStatsStored;

	public static SteamAchievements instance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnGameOverlayActivated(object pCallback)
	{
	}

	private void OnUserStatsReceived(object pCallback)
	{
	}

	private void OnUserStatsStored(object pCallback)
	{
	}

	private void SendStats()
	{
	}

	private void GetStats()
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
}
