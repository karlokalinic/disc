using System;

namespace Epic.OnlineServices.Lobby
{
	public sealed class LobbySearch : Handle
	{
		public const int LobbysearchCopysearchresultbyindexApiLatest = 1;

		public const int LobbysearchFindApiLatest = 1;

		public const int LobbysearchGetsearchresultcountApiLatest = 1;

		public const int LobbysearchRemoveparameterApiLatest = 1;

		public const int LobbysearchSetlobbyidApiLatest = 1;

		public const int LobbysearchSetmaxresultsApiLatest = 1;

		public const int LobbysearchSetparameterApiLatest = 1;

		public const int LobbysearchSettargetuseridApiLatest = 1;

		public LobbySearch()
		{
		}

		public LobbySearch(IntPtr innerHandle)
		{
		}

		public Result CopySearchResultByIndex(LobbySearchCopySearchResultByIndexOptions options, out LobbyDetails outLobbyDetailsHandle)
		{
			outLobbyDetailsHandle = null;
			return default(Result);
		}

		public void Find(LobbySearchFindOptions options, object clientData, LobbySearchOnFindCallback completionDelegate)
		{
		}

		public uint GetSearchResultCount(LobbySearchGetSearchResultCountOptions options)
		{
			return 0u;
		}

		public void Release()
		{
		}

		public Result RemoveParameter(LobbySearchRemoveParameterOptions options)
		{
			return default(Result);
		}

		public Result SetLobbyId(LobbySearchSetLobbyIdOptions options)
		{
			return default(Result);
		}

		public Result SetMaxResults(LobbySearchSetMaxResultsOptions options)
		{
			return default(Result);
		}

		public Result SetParameter(LobbySearchSetParameterOptions options)
		{
			return default(Result);
		}

		public Result SetTargetUserId(LobbySearchSetTargetUserIdOptions options)
		{
			return default(Result);
		}

		internal static void OnFindCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
