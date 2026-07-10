using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IStats : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IStats(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IStats obj)
		{
			return default(HandleRef);
		}

		~IStats()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void RequestUserStatsAndAchievements(GalaxyID userID, IUserStatsAndAchievementsRetrieveListener listener)
		{
		}

		public virtual void RequestUserStatsAndAchievements(GalaxyID userID)
		{
		}

		public virtual void RequestUserStatsAndAchievements()
		{
		}

		public virtual int GetStatInt(string name, GalaxyID userID)
		{
			return 0;
		}

		public virtual int GetStatInt(string name)
		{
			return 0;
		}

		public virtual float GetStatFloat(string name, GalaxyID userID)
		{
			return 0f;
		}

		public virtual float GetStatFloat(string name)
		{
			return 0f;
		}

		public virtual void SetStatInt(string name, int value)
		{
		}

		public virtual void SetStatFloat(string name, float value)
		{
		}

		public virtual void UpdateAvgRateStat(string name, float countThisSession, double sessionLength)
		{
		}

		public virtual uint GetAchievementsNumber()
		{
			return 0u;
		}

		public virtual string GetAchievementName(uint index)
		{
			return null;
		}

		public virtual void GetAchievementNameCopy(uint index, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual void GetAchievement(string name, ref bool unlocked, ref uint unlockTime, GalaxyID userID)
		{
		}

		public virtual void GetAchievement(string name, ref bool unlocked, ref uint unlockTime)
		{
		}

		public virtual void SetAchievement(string name)
		{
		}

		public virtual void ClearAchievement(string name)
		{
		}

		public virtual void StoreStatsAndAchievements(IStatsAndAchievementsStoreListener listener)
		{
		}

		public virtual void StoreStatsAndAchievements()
		{
		}

		public virtual void ResetStatsAndAchievements(IStatsAndAchievementsStoreListener listener)
		{
		}

		public virtual void ResetStatsAndAchievements()
		{
		}

		public virtual string GetAchievementDisplayName(string name)
		{
			return null;
		}

		public virtual void GetAchievementDisplayNameCopy(string name, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual string GetAchievementDescription(string name)
		{
			return null;
		}

		public virtual void GetAchievementDescriptionCopy(string name, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual bool IsAchievementVisible(string name)
		{
			return false;
		}

		public virtual bool IsAchievementVisibleWhileLocked(string name)
		{
			return false;
		}

		public virtual void RequestLeaderboards(ILeaderboardsRetrieveListener listener)
		{
		}

		public virtual void RequestLeaderboards()
		{
		}

		public virtual string GetLeaderboardDisplayName(string name)
		{
			return null;
		}

		public virtual void GetLeaderboardDisplayNameCopy(string name, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual LeaderboardSortMethod GetLeaderboardSortMethod(string name)
		{
			return default(LeaderboardSortMethod);
		}

		public virtual LeaderboardDisplayType GetLeaderboardDisplayType(string name)
		{
			return default(LeaderboardDisplayType);
		}

		public virtual void RequestLeaderboardEntriesGlobal(string name, uint rangeStart, uint rangeEnd, ILeaderboardEntriesRetrieveListener listener)
		{
		}

		public virtual void RequestLeaderboardEntriesGlobal(string name, uint rangeStart, uint rangeEnd)
		{
		}

		public virtual void RequestLeaderboardEntriesAroundUser(string name, uint countBefore, uint countAfter, GalaxyID userID, ILeaderboardEntriesRetrieveListener listener)
		{
		}

		public virtual void RequestLeaderboardEntriesAroundUser(string name, uint countBefore, uint countAfter, GalaxyID userID)
		{
		}

		public virtual void RequestLeaderboardEntriesAroundUser(string name, uint countBefore, uint countAfter)
		{
		}

		public virtual void RequestLeaderboardEntriesForUsers(string name, ref GalaxyID[] userArray, ILeaderboardEntriesRetrieveListener listener)
		{
		}

		public virtual void RequestLeaderboardEntriesForUsers(string name, ref GalaxyID[] userArray)
		{
		}

		public virtual void GetRequestedLeaderboardEntry(uint index, ref uint rank, ref int score, ref GalaxyID userID)
		{
		}

		public virtual void GetRequestedLeaderboardEntryWithDetails(uint index, ref uint rank, ref int score, byte[] details, uint detailsSize, ref uint outDetailsSize, ref GalaxyID userID)
		{
		}

		public virtual void SetLeaderboardScore(string name, int score, bool forceUpdate, ILeaderboardScoreUpdateListener listener)
		{
		}

		public virtual void SetLeaderboardScore(string name, int score, bool forceUpdate)
		{
		}

		public virtual void SetLeaderboardScore(string name, int score)
		{
		}

		public virtual void SetLeaderboardScoreWithDetails(string name, int score, byte[] details, uint detailsSize, bool forceUpdate, ILeaderboardScoreUpdateListener listener)
		{
		}

		public virtual void SetLeaderboardScoreWithDetails(string name, int score, byte[] details, uint detailsSize, bool forceUpdate)
		{
		}

		public virtual void SetLeaderboardScoreWithDetails(string name, int score, byte[] details, uint detailsSize)
		{
		}

		public virtual uint GetLeaderboardEntryCount(string name)
		{
			return 0u;
		}

		public virtual void FindLeaderboard(string name, ILeaderboardRetrieveListener listener)
		{
		}

		public virtual void FindLeaderboard(string name)
		{
		}

		public virtual void FindOrCreateLeaderboard(string name, string displayName, LeaderboardSortMethod sortMethod, LeaderboardDisplayType displayType, ILeaderboardRetrieveListener listener)
		{
		}

		public virtual void FindOrCreateLeaderboard(string name, string displayName, LeaderboardSortMethod sortMethod, LeaderboardDisplayType displayType)
		{
		}

		public virtual void RequestUserTimePlayed(GalaxyID userID, IUserTimePlayedRetrieveListener listener)
		{
		}

		public virtual void RequestUserTimePlayed(GalaxyID userID)
		{
		}

		public virtual void RequestUserTimePlayed()
		{
		}

		public virtual uint GetUserTimePlayed(GalaxyID userID)
		{
			return 0u;
		}

		public virtual uint GetUserTimePlayed()
		{
			return 0u;
		}
	}
}
