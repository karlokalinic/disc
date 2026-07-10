using System;

namespace Epic.OnlineServices.Auth
{
	public sealed class AuthInterface : Handle
	{
		public const int AccountfeaturerestrictedinfoApiLatest = 1;

		public const int AddnotifyloginstatuschangedApiLatest = 1;

		public const int CopyidtokenApiLatest = 1;

		public const int CopyuserauthtokenApiLatest = 1;

		public const int CredentialsApiLatest = 3;

		public const int DeletepersistentauthApiLatest = 2;

		public const int IdtokenApiLatest = 1;

		public const int LinkaccountApiLatest = 1;

		public const int LoginApiLatest = 2;

		public const int LogoutApiLatest = 1;

		public const int PingrantinfoApiLatest = 2;

		public const int QueryidtokenApiLatest = 1;

		public const int TokenApiLatest = 2;

		public const int VerifyidtokenApiLatest = 1;

		public const int VerifyuserauthApiLatest = 1;

		public const int AuthIoscredentialssystemauthcredentialsoptionsApiLatest = 1;

		public AuthInterface()
		{
		}

		public AuthInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyLoginStatusChanged(AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification)
		{
			return 0uL;
		}

		public Result CopyIdToken(CopyIdTokenOptions options, out IdToken outIdToken)
		{
			outIdToken = null;
			return default(Result);
		}

		public Result CopyUserAuthToken(CopyUserAuthTokenOptions options, EpicAccountId localUserId, out Token outUserAuthToken)
		{
			outUserAuthToken = null;
			return default(Result);
		}

		public void DeletePersistentAuth(DeletePersistentAuthOptions options, object clientData, OnDeletePersistentAuthCallback completionDelegate)
		{
		}

		public EpicAccountId GetLoggedInAccountByIndex(int index)
		{
			return null;
		}

		public int GetLoggedInAccountsCount()
		{
			return 0;
		}

		public LoginStatus GetLoginStatus(EpicAccountId localUserId)
		{
			return default(LoginStatus);
		}

		public EpicAccountId GetMergedAccountByIndex(EpicAccountId localUserId, uint index)
		{
			return null;
		}

		public uint GetMergedAccountsCount(EpicAccountId localUserId)
		{
			return 0u;
		}

		public Result GetSelectedAccountId(EpicAccountId localUserId, out EpicAccountId outSelectedAccountId)
		{
			outSelectedAccountId = null;
			return default(Result);
		}

		public void LinkAccount(LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate)
		{
		}

		public void Login(LoginOptions options, object clientData, OnLoginCallback completionDelegate)
		{
		}

		public void Logout(LogoutOptions options, object clientData, OnLogoutCallback completionDelegate)
		{
		}

		public void QueryIdToken(QueryIdTokenOptions options, object clientData, OnQueryIdTokenCallback completionDelegate)
		{
		}

		public void RemoveNotifyLoginStatusChanged(ulong inId)
		{
		}

		public void VerifyIdToken(VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate)
		{
		}

		public void VerifyUserAuth(VerifyUserAuthOptions options, object clientData, OnVerifyUserAuthCallback completionDelegate)
		{
		}

		internal static void OnDeletePersistentAuthCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnLinkAccountCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnLoginCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnLoginStatusChangedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnLogoutCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryIdTokenCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnVerifyIdTokenCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnVerifyUserAuthCallbackInternalImplementation(IntPtr data)
		{
		}

		public void Login(IOSLoginOptions options, object clientData, OnLoginCallback completionDelegate)
		{
		}
	}
}
