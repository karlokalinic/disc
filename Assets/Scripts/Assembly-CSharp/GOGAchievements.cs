using Galaxy.Api;
using UnityEngine;

public class GOGAchievements : MonoBehaviour
{
	private class UserStatsAndAchievementsRetrieveListener : GlobalUserStatsAndAchievementsRetrieveListener
	{
		public bool retrieved;

		public override void OnUserStatsAndAchievementsRetrieveSuccess(GalaxyID userID)
		{
		}

		public override void OnUserStatsAndAchievementsRetrieveFailure(GalaxyID userID, FailureReason failureReason)
		{
		}
	}

	private class StatsAndAchievementsStoreListener : GlobalStatsAndAchievementsStoreListener
	{
		public override void OnUserStatsAndAchievementsStoreFailure(FailureReason failureReason)
		{
		}

		public override void OnUserStatsAndAchievementsStoreSuccess()
		{
		}
	}

	private class AchievementChangeListener : GlobalAchievementChangeListener
	{
		public override void OnAchievementUnlocked(string name)
		{
		}
	}

	private UserStatsAndAchievementsRetrieveListener achievementRetrieveListener;

	private AchievementChangeListener achievementChangeListener;

	private StatsAndAchievementsStoreListener achievementStoreListener;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ListenersInit()
	{
	}

	private void ListenersDispose()
	{
	}

	public void RequestUserStatsAndAchievements()
	{
	}

	public bool SetAchievement(string apiKey)
	{
		return false;
	}

	public bool GetAchievement(string apiKey)
	{
		return false;
	}

	public string GetAchievementName(string apiKey)
	{
		return null;
	}

	public bool ClearAchievementName(string apiKey)
	{
		return false;
	}

	public bool SetStatFloat(string apiKey, float statValue)
	{
		return false;
	}

	public bool SetStatInt(string apiKey, int statValue)
	{
		return false;
	}

	public float GetStatFloat(string apiKey)
	{
		return 0f;
	}

	public int GetStatInt(string apiKey)
	{
		return 0;
	}

	public bool ResetStatsAndAchievements()
	{
		return false;
	}
}
