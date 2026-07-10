using System;

namespace Epic.OnlineServices.RTCAdmin
{
	public sealed class RTCAdminInterface : Handle
	{
		public const int CopyusertokenbyindexApiLatest = 2;

		public const int CopyusertokenbyuseridApiLatest = 2;

		public const int KickApiLatest = 1;

		public const int QueryjoinroomtokenApiLatest = 2;

		public const int SetparticipanthardmuteApiLatest = 1;

		public const int UsertokenApiLatest = 1;

		public RTCAdminInterface()
		{
		}

		public RTCAdminInterface(IntPtr innerHandle)
		{
		}

		public Result CopyUserTokenByIndex(CopyUserTokenByIndexOptions options, out UserToken outUserToken)
		{
			outUserToken = null;
			return default(Result);
		}

		public Result CopyUserTokenByUserId(CopyUserTokenByUserIdOptions options, out UserToken outUserToken)
		{
			outUserToken = null;
			return default(Result);
		}

		public void Kick(KickOptions options, object clientData, OnKickCompleteCallback completionDelegate)
		{
		}

		public void QueryJoinRoomToken(QueryJoinRoomTokenOptions options, object clientData, OnQueryJoinRoomTokenCompleteCallback completionDelegate)
		{
		}

		public void SetParticipantHardMute(SetParticipantHardMuteOptions options, object clientData, OnSetParticipantHardMuteCompleteCallback completionDelegate)
		{
		}

		internal static void OnKickCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryJoinRoomTokenCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnSetParticipantHardMuteCompleteCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
