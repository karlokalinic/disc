using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IFriends : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IFriends(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IFriends obj)
		{
			return default(HandleRef);
		}

		~IFriends()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual uint GetDefaultAvatarCriteria()
		{
			return 0u;
		}

		public virtual void SetDefaultAvatarCriteria(uint defaultAvatarCriteria)
		{
		}

		public virtual void RequestUserInformation(GalaxyID userID, uint avatarCriteria, IUserInformationRetrieveListener listener)
		{
		}

		public virtual void RequestUserInformation(GalaxyID userID, uint avatarCriteria)
		{
		}

		public virtual void RequestUserInformation(GalaxyID userID)
		{
		}

		public virtual bool IsUserInformationAvailable(GalaxyID userID)
		{
			return false;
		}

		public virtual string GetPersonaName()
		{
			return null;
		}

		public virtual void GetPersonaNameCopy(out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual PersonaState GetPersonaState()
		{
			return default(PersonaState);
		}

		public virtual string GetFriendPersonaName(GalaxyID userID)
		{
			return null;
		}

		public virtual void GetFriendPersonaNameCopy(GalaxyID userID, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual PersonaState GetFriendPersonaState(GalaxyID userID)
		{
			return default(PersonaState);
		}

		public virtual string GetFriendAvatarUrl(GalaxyID userID, AvatarType avatarType)
		{
			return null;
		}

		public virtual void GetFriendAvatarUrlCopy(GalaxyID userID, AvatarType avatarType, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual uint GetFriendAvatarImageID(GalaxyID userID, AvatarType avatarType)
		{
			return 0u;
		}

		public virtual void GetFriendAvatarImageRGBA(GalaxyID userID, AvatarType avatarType, byte[] buffer, uint bufferLength)
		{
		}

		public virtual bool IsFriendAvatarImageRGBAAvailable(GalaxyID userID, AvatarType avatarType)
		{
			return false;
		}

		public virtual void RequestFriendList(IFriendListListener listener)
		{
		}

		public virtual void RequestFriendList()
		{
		}

		public virtual bool IsFriend(GalaxyID userID)
		{
			return false;
		}

		public virtual uint GetFriendCount()
		{
			return 0u;
		}

		public virtual GalaxyID GetFriendByIndex(uint index)
		{
			return null;
		}

		public virtual void SendFriendInvitation(GalaxyID userID, IFriendInvitationSendListener listener)
		{
		}

		public virtual void SendFriendInvitation(GalaxyID userID)
		{
		}

		public virtual void RequestFriendInvitationList(IFriendInvitationListRetrieveListener listener)
		{
		}

		public virtual void RequestFriendInvitationList()
		{
		}

		public virtual void RequestSentFriendInvitationList(ISentFriendInvitationListRetrieveListener listener)
		{
		}

		public virtual void RequestSentFriendInvitationList()
		{
		}

		public virtual uint GetFriendInvitationCount()
		{
			return 0u;
		}

		public virtual void GetFriendInvitationByIndex(uint index, ref GalaxyID userID, ref uint sendTime)
		{
		}

		public virtual void RespondToFriendInvitation(GalaxyID userID, bool accept, IFriendInvitationRespondToListener listener)
		{
		}

		public virtual void RespondToFriendInvitation(GalaxyID userID, bool accept)
		{
		}

		public virtual void DeleteFriend(GalaxyID userID, IFriendDeleteListener listener)
		{
		}

		public virtual void DeleteFriend(GalaxyID userID)
		{
		}

		public virtual void SetRichPresence(string key, string value, IRichPresenceChangeListener listener)
		{
		}

		public virtual void SetRichPresence(string key, string value)
		{
		}

		public virtual void DeleteRichPresence(string key, IRichPresenceChangeListener listener)
		{
		}

		public virtual void DeleteRichPresence(string key)
		{
		}

		public virtual void ClearRichPresence(IRichPresenceChangeListener listener)
		{
		}

		public virtual void ClearRichPresence()
		{
		}

		public virtual void RequestRichPresence(GalaxyID userID, IRichPresenceRetrieveListener listener)
		{
		}

		public virtual void RequestRichPresence(GalaxyID userID)
		{
		}

		public virtual void RequestRichPresence()
		{
		}

		public virtual string GetRichPresence(string key, GalaxyID userID)
		{
			return null;
		}

		public virtual string GetRichPresence(string key)
		{
			return null;
		}

		public virtual void GetRichPresenceCopy(string key, out string buffer, uint bufferLength, GalaxyID userID)
		{
			buffer = null;
		}

		public virtual void GetRichPresenceCopy(string key, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual uint GetRichPresenceCount(GalaxyID userID)
		{
			return 0u;
		}

		public virtual uint GetRichPresenceCount()
		{
			return 0u;
		}

		public virtual void GetRichPresenceByIndex(uint index, ref byte[] key, uint keyLength, ref byte[] value, uint valueLength, GalaxyID userID)
		{
		}

		public virtual void GetRichPresenceByIndex(uint index, ref byte[] key, uint keyLength, ref byte[] value, uint valueLength)
		{
		}

		public virtual string GetRichPresenceKeyByIndex(uint index, GalaxyID userID)
		{
			return null;
		}

		public virtual string GetRichPresenceKeyByIndex(uint index)
		{
			return null;
		}

		public virtual void GetRichPresenceKeyByIndexCopy(uint index, out string buffer, uint bufferLength, GalaxyID userID)
		{
			buffer = null;
		}

		public virtual void GetRichPresenceKeyByIndexCopy(uint index, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual void ShowOverlayInviteDialog(string connectionString)
		{
		}

		public virtual void SendInvitation(GalaxyID userID, string connectionString, ISendInvitationListener listener)
		{
		}

		public virtual void SendInvitation(GalaxyID userID, string connectionString)
		{
		}

		public virtual void FindUser(string userSpecifier, IUserFindListener listener)
		{
		}

		public virtual void FindUser(string userSpecifier)
		{
		}

		public virtual bool IsUserInTheSameGame(GalaxyID userID)
		{
			return false;
		}
	}
}
