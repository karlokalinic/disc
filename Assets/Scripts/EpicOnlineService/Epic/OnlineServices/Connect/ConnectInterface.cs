using System;

namespace Epic.OnlineServices.Connect
{
	public sealed class ConnectInterface : Handle
	{
		public const int AddnotifyauthexpirationApiLatest = 1;

		public const int AddnotifyloginstatuschangedApiLatest = 1;

		public const int CopyidtokenApiLatest = 1;

		public const int CopyproductuserexternalaccountbyaccountidApiLatest = 1;

		public const int CopyproductuserexternalaccountbyaccounttypeApiLatest = 1;

		public const int CopyproductuserexternalaccountbyindexApiLatest = 1;

		public const int CopyproductuserinfoApiLatest = 1;

		public const int CreatedeviceidApiLatest = 1;

		public const int CreatedeviceidDevicemodelMaxLength = 64;

		public const int CreateuserApiLatest = 1;

		public const int CredentialsApiLatest = 1;

		public const int DeletedeviceidApiLatest = 1;

		public const int ExternalAccountIdMaxLength = 256;

		public const int ExternalaccountinfoApiLatest = 1;

		public const int GetexternalaccountmappingApiLatest = 1;

		public const int GetexternalaccountmappingsApiLatest = 1;

		public const int GetproductuserexternalaccountcountApiLatest = 1;

		public const int GetproductuseridmappingApiLatest = 1;

		public const int IdtokenApiLatest = 1;

		public const int LinkaccountApiLatest = 1;

		public const int LoginApiLatest = 2;

		public const int OnauthexpirationcallbackApiLatest = 1;

		public const int QueryexternalaccountmappingsApiLatest = 1;

		public const int QueryexternalaccountmappingsMaxAccountIds = 128;

		public const int QueryproductuseridmappingsApiLatest = 2;

		public const int TimeUndefined = -1;

		public const int TransferdeviceidaccountApiLatest = 1;

		public const int UnlinkaccountApiLatest = 1;

		public const int UserlogininfoApiLatest = 1;

		public const int UserlogininfoDisplaynameMaxLength = 32;

		public const int VerifyidtokenApiLatest = 1;

		public ConnectInterface()
		{
		}

		public ConnectInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyAuthExpiration(AddNotifyAuthExpirationOptions options, object clientData, OnAuthExpirationCallback notification)
		{
			return 0uL;
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

		public Result CopyProductUserExternalAccountByAccountId(CopyProductUserExternalAccountByAccountIdOptions options, out ExternalAccountInfo outExternalAccountInfo)
		{
			outExternalAccountInfo = null;
			return default(Result);
		}

		public Result CopyProductUserExternalAccountByAccountType(CopyProductUserExternalAccountByAccountTypeOptions options, out ExternalAccountInfo outExternalAccountInfo)
		{
			outExternalAccountInfo = null;
			return default(Result);
		}

		public Result CopyProductUserExternalAccountByIndex(CopyProductUserExternalAccountByIndexOptions options, out ExternalAccountInfo outExternalAccountInfo)
		{
			outExternalAccountInfo = null;
			return default(Result);
		}

		public Result CopyProductUserInfo(CopyProductUserInfoOptions options, out ExternalAccountInfo outExternalAccountInfo)
		{
			outExternalAccountInfo = null;
			return default(Result);
		}

		public void CreateDeviceId(CreateDeviceIdOptions options, object clientData, OnCreateDeviceIdCallback completionDelegate)
		{
		}

		public void CreateUser(CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate)
		{
		}

		public void DeleteDeviceId(DeleteDeviceIdOptions options, object clientData, OnDeleteDeviceIdCallback completionDelegate)
		{
		}

		public ProductUserId GetExternalAccountMapping(GetExternalAccountMappingsOptions options)
		{
			return null;
		}

		public ProductUserId GetLoggedInUserByIndex(int index)
		{
			return null;
		}

		public int GetLoggedInUsersCount()
		{
			return 0;
		}

		public LoginStatus GetLoginStatus(ProductUserId localUserId)
		{
			return default(LoginStatus);
		}

		public uint GetProductUserExternalAccountCount(GetProductUserExternalAccountCountOptions options)
		{
			return 0u;
		}

		public Result GetProductUserIdMapping(GetProductUserIdMappingOptions options, out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public void LinkAccount(LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate)
		{
		}

		public void Login(LoginOptions options, object clientData, OnLoginCallback completionDelegate)
		{
		}

		public void QueryExternalAccountMappings(QueryExternalAccountMappingsOptions options, object clientData, OnQueryExternalAccountMappingsCallback completionDelegate)
		{
		}

		public void QueryProductUserIdMappings(QueryProductUserIdMappingsOptions options, object clientData, OnQueryProductUserIdMappingsCallback completionDelegate)
		{
		}

		public void RemoveNotifyAuthExpiration(ulong inId)
		{
		}

		public void RemoveNotifyLoginStatusChanged(ulong inId)
		{
		}

		public void TransferDeviceIdAccount(TransferDeviceIdAccountOptions options, object clientData, OnTransferDeviceIdAccountCallback completionDelegate)
		{
		}

		public void UnlinkAccount(UnlinkAccountOptions options, object clientData, OnUnlinkAccountCallback completionDelegate)
		{
		}

		public void VerifyIdToken(VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate)
		{
		}

		internal static void OnAuthExpirationCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnCreateDeviceIdCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnCreateUserCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnDeleteDeviceIdCallbackInternalImplementation(IntPtr data)
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

		internal static void OnQueryExternalAccountMappingsCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryProductUserIdMappingsCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnTransferDeviceIdAccountCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnUnlinkAccountCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnVerifyIdTokenCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
