using System;

namespace Epic.OnlineServices.Sessions
{
	public sealed class ActiveSession : Handle
	{
		public const int ActivesessionCopyinfoApiLatest = 1;

		public const int ActivesessionGetregisteredplayerbyindexApiLatest = 1;

		public const int ActivesessionGetregisteredplayercountApiLatest = 1;

		public const int ActivesessionInfoApiLatest = 1;

		public ActiveSession()
		{
		}

		public ActiveSession(IntPtr innerHandle)
		{
		}

		public Result CopyInfo(ActiveSessionCopyInfoOptions options, out ActiveSessionInfo outActiveSessionInfo)
		{
			outActiveSessionInfo = null;
			return default(Result);
		}

		public ProductUserId GetRegisteredPlayerByIndex(ActiveSessionGetRegisteredPlayerByIndexOptions options)
		{
			return null;
		}

		public uint GetRegisteredPlayerCount(ActiveSessionGetRegisteredPlayerCountOptions options)
		{
			return 0u;
		}

		public void Release()
		{
		}
	}
}
