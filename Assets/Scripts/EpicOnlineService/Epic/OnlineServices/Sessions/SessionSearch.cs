using System;

namespace Epic.OnlineServices.Sessions
{
	public sealed class SessionSearch : Handle
	{
		public const int SessionsearchCopysearchresultbyindexApiLatest = 1;

		public const int SessionsearchFindApiLatest = 2;

		public const int SessionsearchGetsearchresultcountApiLatest = 1;

		public const int SessionsearchRemoveparameterApiLatest = 1;

		public const int SessionsearchSetmaxsearchresultsApiLatest = 1;

		public const int SessionsearchSetparameterApiLatest = 1;

		public const int SessionsearchSetsessionidApiLatest = 1;

		public const int SessionsearchSettargetuseridApiLatest = 1;

		public SessionSearch()
		{
		}

		public SessionSearch(IntPtr innerHandle)
		{
		}

		public Result CopySearchResultByIndex(SessionSearchCopySearchResultByIndexOptions options, out SessionDetails outSessionHandle)
		{
			outSessionHandle = null;
			return default(Result);
		}

		public void Find(SessionSearchFindOptions options, object clientData, SessionSearchOnFindCallback completionDelegate)
		{
		}

		public uint GetSearchResultCount(SessionSearchGetSearchResultCountOptions options)
		{
			return 0u;
		}

		public void Release()
		{
		}

		public Result RemoveParameter(SessionSearchRemoveParameterOptions options)
		{
			return default(Result);
		}

		public Result SetMaxResults(SessionSearchSetMaxResultsOptions options)
		{
			return default(Result);
		}

		public Result SetParameter(SessionSearchSetParameterOptions options)
		{
			return default(Result);
		}

		public Result SetSessionId(SessionSearchSetSessionIdOptions options)
		{
			return default(Result);
		}

		public Result SetTargetUserId(SessionSearchSetTargetUserIdOptions options)
		{
			return default(Result);
		}

		internal static void OnFindCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
