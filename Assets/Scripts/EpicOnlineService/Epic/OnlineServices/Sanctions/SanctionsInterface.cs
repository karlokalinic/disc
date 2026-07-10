using System;

namespace Epic.OnlineServices.Sanctions
{
	public sealed class SanctionsInterface : Handle
	{
		public const int CopyplayersanctionbyindexApiLatest = 1;

		public const int GetplayersanctioncountApiLatest = 1;

		public const int PlayersanctionApiLatest = 2;

		public const int QueryactiveplayersanctionsApiLatest = 2;

		public SanctionsInterface()
		{
		}

		public SanctionsInterface(IntPtr innerHandle)
		{
		}

		public Result CopyPlayerSanctionByIndex(CopyPlayerSanctionByIndexOptions options, out PlayerSanction outSanction)
		{
			outSanction = null;
			return default(Result);
		}

		public uint GetPlayerSanctionCount(GetPlayerSanctionCountOptions options)
		{
			return 0u;
		}

		public void QueryActivePlayerSanctions(QueryActivePlayerSanctionsOptions options, object clientData, OnQueryActivePlayerSanctionsCallback completionDelegate)
		{
		}

		internal static void OnQueryActivePlayerSanctionsCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
