using System;

namespace Epic.OnlineServices.Sessions
{
	public sealed class SessionsInterface : Handle
	{
		public const int AddnotifyjoinsessionacceptedApiLatest = 1;

		public const int AddnotifysessioninviteacceptedApiLatest = 1;

		public const int AddnotifysessioninvitereceivedApiLatest = 1;

		public const int AttributedataApiLatest = 1;

		public const int CopyactivesessionhandleApiLatest = 1;

		public const int CopysessionhandlebyinviteidApiLatest = 1;

		public const int CopysessionhandlebyuieventidApiLatest = 1;

		public const int CopysessionhandleforpresenceApiLatest = 1;

		public const int CreatesessionmodificationApiLatest = 4;

		public const int CreatesessionsearchApiLatest = 1;

		public const int DestroysessionApiLatest = 1;

		public const int DumpsessionstateApiLatest = 1;

		public const int EndsessionApiLatest = 1;

		public const int GetinvitecountApiLatest = 1;

		public const int GetinviteidbyindexApiLatest = 1;

		public const int InviteidMaxLength = 64;

		public const int IsuserinsessionApiLatest = 1;

		public const int JoinsessionApiLatest = 2;

		public const int MaxSearchResults = 200;

		public const int Maxregisteredplayers = 1000;

		public const int QueryinvitesApiLatest = 1;

		public const int RegisterplayersApiLatest = 2;

		public const int RejectinviteApiLatest = 1;

		public const string SearchBucketId = "bucket";

		public const string SearchEmptyServersOnly = "emptyonly";

		public const string SearchMinslotsavailable = "minslotsavailable";

		public const string SearchNonemptyServersOnly = "nonemptyonly";

		public const int SendinviteApiLatest = 1;

		public const int SessionattributeApiLatest = 1;

		public const int SessionattributedataApiLatest = 1;

		public const int StartsessionApiLatest = 1;

		public const int UnregisterplayersApiLatest = 2;

		public const int UpdatesessionApiLatest = 1;

		public const int UpdatesessionmodificationApiLatest = 1;

		public SessionsInterface()
		{
		}

		public SessionsInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyJoinSessionAccepted(AddNotifyJoinSessionAcceptedOptions options, object clientData, OnJoinSessionAcceptedCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifySessionInviteAccepted(AddNotifySessionInviteAcceptedOptions options, object clientData, OnSessionInviteAcceptedCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifySessionInviteReceived(AddNotifySessionInviteReceivedOptions options, object clientData, OnSessionInviteReceivedCallback notificationFn)
		{
			return 0uL;
		}

		public Result CopyActiveSessionHandle(CopyActiveSessionHandleOptions options, out ActiveSession outSessionHandle)
		{
			outSessionHandle = null;
			return default(Result);
		}

		public Result CopySessionHandleByInviteId(CopySessionHandleByInviteIdOptions options, out SessionDetails outSessionHandle)
		{
			outSessionHandle = null;
			return default(Result);
		}

		public Result CopySessionHandleByUiEventId(CopySessionHandleByUiEventIdOptions options, out SessionDetails outSessionHandle)
		{
			outSessionHandle = null;
			return default(Result);
		}

		public Result CopySessionHandleForPresence(CopySessionHandleForPresenceOptions options, out SessionDetails outSessionHandle)
		{
			outSessionHandle = null;
			return default(Result);
		}

		public Result CreateSessionModification(CreateSessionModificationOptions options, out SessionModification outSessionModificationHandle)
		{
			outSessionModificationHandle = null;
			return default(Result);
		}

		public Result CreateSessionSearch(CreateSessionSearchOptions options, out SessionSearch outSessionSearchHandle)
		{
			outSessionSearchHandle = null;
			return default(Result);
		}

		public void DestroySession(DestroySessionOptions options, object clientData, OnDestroySessionCallback completionDelegate)
		{
		}

		public Result DumpSessionState(DumpSessionStateOptions options)
		{
			return default(Result);
		}

		public void EndSession(EndSessionOptions options, object clientData, OnEndSessionCallback completionDelegate)
		{
		}

		public uint GetInviteCount(GetInviteCountOptions options)
		{
			return 0u;
		}

		public Result GetInviteIdByIndex(GetInviteIdByIndexOptions options, out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result IsUserInSession(IsUserInSessionOptions options)
		{
			return default(Result);
		}

		public void JoinSession(JoinSessionOptions options, object clientData, OnJoinSessionCallback completionDelegate)
		{
		}

		public void QueryInvites(QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate)
		{
		}

		public void RegisterPlayers(RegisterPlayersOptions options, object clientData, OnRegisterPlayersCallback completionDelegate)
		{
		}

		public void RejectInvite(RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate)
		{
		}

		public void RemoveNotifyJoinSessionAccepted(ulong inId)
		{
		}

		public void RemoveNotifySessionInviteAccepted(ulong inId)
		{
		}

		public void RemoveNotifySessionInviteReceived(ulong inId)
		{
		}

		public void SendInvite(SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
		{
		}

		public void StartSession(StartSessionOptions options, object clientData, OnStartSessionCallback completionDelegate)
		{
		}

		public void UnregisterPlayers(UnregisterPlayersOptions options, object clientData, OnUnregisterPlayersCallback completionDelegate)
		{
		}

		public void UpdateSession(UpdateSessionOptions options, object clientData, OnUpdateSessionCallback completionDelegate)
		{
		}

		public Result UpdateSessionModification(UpdateSessionModificationOptions options, out SessionModification outSessionModificationHandle)
		{
			outSessionModificationHandle = null;
			return default(Result);
		}

		internal static void OnDestroySessionCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnEndSessionCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnJoinSessionAcceptedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnJoinSessionCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryInvitesCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnRegisterPlayersCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnRejectInviteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnSendInviteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnSessionInviteAcceptedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnSessionInviteReceivedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnStartSessionCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnUnregisterPlayersCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnUpdateSessionCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
