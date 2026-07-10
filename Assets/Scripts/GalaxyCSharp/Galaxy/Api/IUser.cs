using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IUser : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IUser(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IUser obj)
		{
			return default(HandleRef);
		}

		~IUser()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual bool SignedIn()
		{
			return false;
		}

		public virtual GalaxyID GetGalaxyID()
		{
			return null;
		}

		public virtual void SignInCredentials(string login, string password, IAuthListener listener)
		{
		}

		public virtual void SignInCredentials(string login, string password)
		{
		}

		public virtual void SignInToken(string refreshToken, IAuthListener listener)
		{
		}

		public virtual void SignInToken(string refreshToken)
		{
		}

		public virtual void SignInLauncher(IAuthListener listener)
		{
		}

		public virtual void SignInLauncher()
		{
		}

		public virtual void SignInSteam(byte[] steamAppTicket, uint steamAppTicketSize, string personaName, IAuthListener listener)
		{
		}

		public virtual void SignInSteam(byte[] steamAppTicket, uint steamAppTicketSize, string personaName)
		{
		}

		public virtual void SignInGalaxy(bool requireOnline, uint timeout, IAuthListener listener)
		{
		}

		public virtual void SignInGalaxy(bool requireOnline, uint timeout)
		{
		}

		public virtual void SignInGalaxy(bool requireOnline)
		{
		}

		public virtual void SignInGalaxy()
		{
		}

		public virtual void SignInPS4(string ps4ClientID, IAuthListener listener)
		{
		}

		public virtual void SignInPS4(string ps4ClientID)
		{
		}

		public virtual void SignInXB1(string xboxOneUserID, IAuthListener listener)
		{
		}

		public virtual void SignInXB1(string xboxOneUserID)
		{
		}

		public virtual void SignInXbox(ulong xboxID, IAuthListener listener)
		{
		}

		public virtual void SignInXbox(ulong xboxID)
		{
		}

		public virtual void SignInXBLive(string token, string signature, string marketplaceID, string locale, IAuthListener listener)
		{
		}

		public virtual void SignInXBLive(string token, string signature, string marketplaceID, string locale)
		{
		}

		public virtual void SignInAnonymous(IAuthListener listener)
		{
		}

		public virtual void SignInAnonymous()
		{
		}

		public virtual void SignInAnonymousTelemetry(IAuthListener listener)
		{
		}

		public virtual void SignInAnonymousTelemetry()
		{
		}

		public virtual void SignInServerKey(string serverKey, IAuthListener listener)
		{
		}

		public virtual void SignInServerKey(string serverKey)
		{
		}

		public virtual void SignInAuthorizationCode(string authorizationCode, string redirectURI, IAuthListener listener)
		{
		}

		public virtual void SignInAuthorizationCode(string authorizationCode, string redirectURI)
		{
		}

		public virtual void SignOut()
		{
		}

		public virtual void RequestUserData(GalaxyID userID, ISpecificUserDataListener listener)
		{
		}

		public virtual void RequestUserData(GalaxyID userID)
		{
		}

		public virtual void RequestUserData()
		{
		}

		public virtual bool IsUserDataAvailable(GalaxyID userID)
		{
			return false;
		}

		public virtual bool IsUserDataAvailable()
		{
			return false;
		}

		public virtual string GetUserData(string key, GalaxyID userID)
		{
			return null;
		}

		public virtual string GetUserData(string key)
		{
			return null;
		}

		public virtual void GetUserDataCopy(string key, out string buffer, uint bufferLength, GalaxyID userID)
		{
			buffer = null;
		}

		public virtual void GetUserDataCopy(string key, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual void SetUserData(string key, string value, ISpecificUserDataListener listener)
		{
		}

		public virtual void SetUserData(string key, string value)
		{
		}

		public virtual uint GetUserDataCount(GalaxyID userID)
		{
			return 0u;
		}

		public virtual uint GetUserDataCount()
		{
			return 0u;
		}

		public virtual bool GetUserDataByIndex(uint index, ref byte[] key, uint keyLength, ref byte[] value, uint valueLength, GalaxyID userID)
		{
			return false;
		}

		public virtual bool GetUserDataByIndex(uint index, ref byte[] key, uint keyLength, ref byte[] value, uint valueLength)
		{
			return false;
		}

		public virtual void DeleteUserData(string key, ISpecificUserDataListener listener)
		{
		}

		public virtual void DeleteUserData(string key)
		{
		}

		public virtual bool IsLoggedOn()
		{
			return false;
		}

		public virtual void RequestEncryptedAppTicket(byte[] data, uint dataSize, IEncryptedAppTicketListener listener)
		{
		}

		public virtual void RequestEncryptedAppTicket(byte[] data, uint dataSize)
		{
		}

		public virtual void GetEncryptedAppTicket(byte[] encryptedAppTicket, uint maxEncryptedAppTicketSize, ref uint currentEncryptedAppTicketSize)
		{
		}

		public virtual void CreateOpenIDConnection(string secretKey, string titleID, string connectionID, bool ignoreNonce, IPlayFabCreateOpenIDConnectionListener listener)
		{
		}

		public virtual void CreateOpenIDConnection(string secretKey, string titleID, string connectionID, bool ignoreNonce)
		{
		}

		public virtual void CreateOpenIDConnection(string secretKey, string titleID, string connectionID)
		{
		}

		public virtual void LoginWithOpenIDConnect(string titleID, string connectionID, string idToken, bool createAccount, string encryptedRequest, string playerSecret, IPlayFabLoginWithOpenIDConnectListener listener)
		{
		}

		public virtual void LoginWithOpenIDConnect(string titleID, string connectionID, string idToken, bool createAccount, string encryptedRequest, string playerSecret)
		{
		}

		public virtual void LoginWithOpenIDConnect(string titleID, string connectionID, string idToken, bool createAccount, string encryptedRequest)
		{
		}

		public virtual void LoginWithOpenIDConnect(string titleID, string connectionID, string idToken, bool createAccount)
		{
		}

		public virtual void LoginWithOpenIDConnect(string titleID, string connectionID, string idToken)
		{
		}

		public virtual ulong GetSessionID()
		{
			return 0uL;
		}

		public virtual string GetAccessToken()
		{
			return null;
		}

		public virtual void GetAccessTokenCopy(out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual string GetRefreshToken()
		{
			return null;
		}

		public virtual void GetRefreshTokenCopy(out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual string GetIDToken()
		{
			return null;
		}

		public virtual void GetIDTokenCopy(out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual bool ReportInvalidAccessToken(string accessToken, string info)
		{
			return false;
		}

		public virtual bool ReportInvalidAccessToken(string accessToken)
		{
			return false;
		}
	}
}
