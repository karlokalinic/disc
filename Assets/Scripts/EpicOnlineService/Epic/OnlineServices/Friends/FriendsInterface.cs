using System;

namespace Epic.OnlineServices.Friends
{
	public sealed class FriendsInterface : Handle
	{
		public const int AcceptinviteApiLatest = 1;

		public const int AddnotifyfriendsupdateApiLatest = 1;

		public const int GetfriendatindexApiLatest = 1;

		public const int GetfriendscountApiLatest = 1;

		public const int GetstatusApiLatest = 1;

		public const int QueryfriendsApiLatest = 1;

		public const int RejectinviteApiLatest = 1;

		public const int SendinviteApiLatest = 1;

		public FriendsInterface()
		{
		}

		public FriendsInterface(IntPtr innerHandle)
		{
		}

		public void AcceptInvite(AcceptInviteOptions options, object clientData, OnAcceptInviteCallback completionDelegate)
		{
		}

		public ulong AddNotifyFriendsUpdate(AddNotifyFriendsUpdateOptions options, object clientData, OnFriendsUpdateCallback friendsUpdateHandler)
		{
			return 0uL;
		}

		public EpicAccountId GetFriendAtIndex(GetFriendAtIndexOptions options)
		{
			return null;
		}

		public int GetFriendsCount(GetFriendsCountOptions options)
		{
			return 0;
		}

		public FriendsStatus GetStatus(GetStatusOptions options)
		{
			return default(FriendsStatus);
		}

		public void QueryFriends(QueryFriendsOptions options, object clientData, OnQueryFriendsCallback completionDelegate)
		{
		}

		public void RejectInvite(RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate)
		{
		}

		public void RemoveNotifyFriendsUpdate(ulong notificationId)
		{
		}

		public void SendInvite(SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
		{
		}

		internal static void OnAcceptInviteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnFriendsUpdateCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryFriendsCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnRejectInviteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnSendInviteCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
