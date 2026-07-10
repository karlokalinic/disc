using System;

namespace Epic.OnlineServices.Leaderboards
{
	public sealed class LeaderboardsInterface : Handle
	{
		public const int CopyleaderboarddefinitionbyindexApiLatest = 1;

		public const int CopyleaderboarddefinitionbyleaderboardidApiLatest = 1;

		public const int CopyleaderboardrecordbyindexApiLatest = 2;

		public const int CopyleaderboardrecordbyuseridApiLatest = 2;

		public const int CopyleaderboarduserscorebyindexApiLatest = 1;

		public const int CopyleaderboarduserscorebyuseridApiLatest = 1;

		public const int DefinitionApiLatest = 1;

		public const int GetleaderboarddefinitioncountApiLatest = 1;

		public const int GetleaderboardrecordcountApiLatest = 1;

		public const int GetleaderboarduserscorecountApiLatest = 1;

		public const int LeaderboardrecordApiLatest = 2;

		public const int LeaderboarduserscoreApiLatest = 1;

		public const int QueryleaderboarddefinitionsApiLatest = 2;

		public const int QueryleaderboardranksApiLatest = 2;

		public const int QueryleaderboarduserscoresApiLatest = 2;

		public const int TimeUndefined = -1;

		public const int UserscoresquerystatinfoApiLatest = 1;

		public LeaderboardsInterface()
		{
		}

		public LeaderboardsInterface(IntPtr innerHandle)
		{
		}

		public Result CopyLeaderboardDefinitionByIndex(CopyLeaderboardDefinitionByIndexOptions options, out Definition outLeaderboardDefinition)
		{
			outLeaderboardDefinition = null;
			return default(Result);
		}

		public Result CopyLeaderboardDefinitionByLeaderboardId(CopyLeaderboardDefinitionByLeaderboardIdOptions options, out Definition outLeaderboardDefinition)
		{
			outLeaderboardDefinition = null;
			return default(Result);
		}

		public Result CopyLeaderboardRecordByIndex(CopyLeaderboardRecordByIndexOptions options, out LeaderboardRecord outLeaderboardRecord)
		{
			outLeaderboardRecord = null;
			return default(Result);
		}

		public Result CopyLeaderboardRecordByUserId(CopyLeaderboardRecordByUserIdOptions options, out LeaderboardRecord outLeaderboardRecord)
		{
			outLeaderboardRecord = null;
			return default(Result);
		}

		public Result CopyLeaderboardUserScoreByIndex(CopyLeaderboardUserScoreByIndexOptions options, out LeaderboardUserScore outLeaderboardUserScore)
		{
			outLeaderboardUserScore = null;
			return default(Result);
		}

		public Result CopyLeaderboardUserScoreByUserId(CopyLeaderboardUserScoreByUserIdOptions options, out LeaderboardUserScore outLeaderboardUserScore)
		{
			outLeaderboardUserScore = null;
			return default(Result);
		}

		public uint GetLeaderboardDefinitionCount(GetLeaderboardDefinitionCountOptions options)
		{
			return 0u;
		}

		public uint GetLeaderboardRecordCount(GetLeaderboardRecordCountOptions options)
		{
			return 0u;
		}

		public uint GetLeaderboardUserScoreCount(GetLeaderboardUserScoreCountOptions options)
		{
			return 0u;
		}

		public void QueryLeaderboardDefinitions(QueryLeaderboardDefinitionsOptions options, object clientData, OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate)
		{
		}

		public void QueryLeaderboardRanks(QueryLeaderboardRanksOptions options, object clientData, OnQueryLeaderboardRanksCompleteCallback completionDelegate)
		{
		}

		public void QueryLeaderboardUserScores(QueryLeaderboardUserScoresOptions options, object clientData, OnQueryLeaderboardUserScoresCompleteCallback completionDelegate)
		{
		}

		internal static void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
