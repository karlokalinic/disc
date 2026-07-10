using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IMatchmaking : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IMatchmaking(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IMatchmaking obj)
		{
			return default(HandleRef);
		}

		~IMatchmaking()
		{
		}

		public virtual void Dispose()
		{
		}

		public bool SendLobbyMessage(GalaxyID lobbyID, string msg)
		{
			return false;
		}

		public uint GetLobbyMessage(GalaxyID lobbyID, uint messageID, ref GalaxyID _senderID, out string msg, uint internalBufferLen = 1024u)
		{
			msg = null;
			return 0u;
		}

		public virtual void CreateLobby(LobbyType lobbyType, uint maxMembers, bool joinable, LobbyTopologyType lobbyTopologyType, ILobbyCreatedListener lobbyCreatedListener, ILobbyEnteredListener lobbyEnteredListener)
		{
		}

		public virtual void CreateLobby(LobbyType lobbyType, uint maxMembers, bool joinable, LobbyTopologyType lobbyTopologyType, ILobbyCreatedListener lobbyCreatedListener)
		{
		}

		public virtual void CreateLobby(LobbyType lobbyType, uint maxMembers, bool joinable, LobbyTopologyType lobbyTopologyType)
		{
		}

		public virtual void RequestLobbyList(bool allowFullLobbies, ILobbyListListener listener)
		{
		}

		public virtual void RequestLobbyList(bool allowFullLobbies)
		{
		}

		public virtual void RequestLobbyList()
		{
		}

		public virtual void AddRequestLobbyListResultCountFilter(uint limit)
		{
		}

		public virtual void AddRequestLobbyListStringFilter(string keyToMatch, string valueToMatch, LobbyComparisonType comparisonType)
		{
		}

		public virtual void AddRequestLobbyListNumericalFilter(string keyToMatch, int valueToMatch, LobbyComparisonType comparisonType)
		{
		}

		public virtual void AddRequestLobbyListNearValueFilter(string keyToMatch, int valueToBeCloseTo)
		{
		}

		public virtual GalaxyID GetLobbyByIndex(uint index)
		{
			return null;
		}

		public virtual void JoinLobby(GalaxyID lobbyID, ILobbyEnteredListener listener)
		{
		}

		public virtual void JoinLobby(GalaxyID lobbyID)
		{
		}

		public virtual void LeaveLobby(GalaxyID lobbyID, ILobbyLeftListener listener)
		{
		}

		public virtual void LeaveLobby(GalaxyID lobbyID)
		{
		}

		public virtual void SetMaxNumLobbyMembers(GalaxyID lobbyID, uint maxNumLobbyMembers, ILobbyDataUpdateListener listener)
		{
		}

		public virtual void SetMaxNumLobbyMembers(GalaxyID lobbyID, uint maxNumLobbyMembers)
		{
		}

		public virtual uint GetMaxNumLobbyMembers(GalaxyID lobbyID)
		{
			return 0u;
		}

		public virtual uint GetNumLobbyMembers(GalaxyID lobbyID)
		{
			return 0u;
		}

		public virtual GalaxyID GetLobbyMemberByIndex(GalaxyID lobbyID, uint index)
		{
			return null;
		}

		public virtual void SetLobbyType(GalaxyID lobbyID, LobbyType lobbyType, ILobbyDataUpdateListener listener)
		{
		}

		public virtual void SetLobbyType(GalaxyID lobbyID, LobbyType lobbyType)
		{
		}

		public virtual LobbyType GetLobbyType(GalaxyID lobbyID)
		{
			return default(LobbyType);
		}

		public virtual void SetLobbyJoinable(GalaxyID lobbyID, bool joinable, ILobbyDataUpdateListener listener)
		{
		}

		public virtual void SetLobbyJoinable(GalaxyID lobbyID, bool joinable)
		{
		}

		public virtual bool IsLobbyJoinable(GalaxyID lobbyID)
		{
			return false;
		}

		public virtual void RequestLobbyData(GalaxyID lobbyID, ILobbyDataRetrieveListener listener)
		{
		}

		public virtual void RequestLobbyData(GalaxyID lobbyID)
		{
		}

		public virtual string GetLobbyData(GalaxyID lobbyID, string key)
		{
			return null;
		}

		public virtual void GetLobbyDataCopy(GalaxyID lobbyID, string key, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual void SetLobbyData(GalaxyID lobbyID, string key, string value, ILobbyDataUpdateListener listener)
		{
		}

		public virtual void SetLobbyData(GalaxyID lobbyID, string key, string value)
		{
		}

		public virtual uint GetLobbyDataCount(GalaxyID lobbyID)
		{
			return 0u;
		}

		public virtual bool GetLobbyDataByIndex(GalaxyID lobbyID, uint index, ref byte[] key, uint keyLength, ref byte[] value, uint valueLength)
		{
			return false;
		}

		public virtual void DeleteLobbyData(GalaxyID lobbyID, string key, ILobbyDataUpdateListener listener)
		{
		}

		public virtual void DeleteLobbyData(GalaxyID lobbyID, string key)
		{
		}

		public virtual string GetLobbyMemberData(GalaxyID lobbyID, GalaxyID memberID, string key)
		{
			return null;
		}

		public virtual void GetLobbyMemberDataCopy(GalaxyID lobbyID, GalaxyID memberID, string key, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual void SetLobbyMemberData(GalaxyID lobbyID, string key, string value, ILobbyMemberDataUpdateListener listener)
		{
		}

		public virtual void SetLobbyMemberData(GalaxyID lobbyID, string key, string value)
		{
		}

		public virtual uint GetLobbyMemberDataCount(GalaxyID lobbyID, GalaxyID memberID)
		{
			return 0u;
		}

		public virtual bool GetLobbyMemberDataByIndex(GalaxyID lobbyID, GalaxyID memberID, uint index, ref byte[] key, uint keyLength, ref byte[] value, uint valueLength)
		{
			return false;
		}

		public virtual void DeleteLobbyMemberData(GalaxyID lobbyID, string key, ILobbyMemberDataUpdateListener listener)
		{
		}

		public virtual void DeleteLobbyMemberData(GalaxyID lobbyID, string key)
		{
		}

		public virtual GalaxyID GetLobbyOwner(GalaxyID lobbyID)
		{
			return null;
		}

		public virtual bool SendLobbyMessage(GalaxyID lobbyID, byte[] data, uint dataSize)
		{
			return false;
		}

		public virtual uint GetLobbyMessage(GalaxyID lobbyID, uint messageID, ref GalaxyID senderID, ref byte[] msg, uint msgLength)
		{
			return 0u;
		}
	}
}
