using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.AntiCheatClient;
using Epic.OnlineServices.AntiCheatServer;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.CustomInvites;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Leaderboards;
using Epic.OnlineServices.Lobby;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.ProgressionSnapshot;
using Epic.OnlineServices.RTC;
using Epic.OnlineServices.RTCAdmin;
using Epic.OnlineServices.RTCAudio;
using Epic.OnlineServices.Reports;
using Epic.OnlineServices.Sanctions;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;
using Epic.OnlineServices.UserInfo;

namespace Epic.OnlineServices
{
	public static class Bindings
	{
		[PreserveSig]
		internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, IntPtr options, IntPtr clientData, OnAchievementsUnlockedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, IntPtr options, IntPtr clientData, OnAchievementsUnlockedCallbackV2Internal notificationFn);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

		[PreserveSig]
		internal static extern void EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition);

		[PreserveSig]
		internal static extern void EOS_Achievements_Definition_Release(IntPtr achievementDefinition);

		[PreserveSig]
		internal static extern uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement);

		[PreserveSig]
		internal static extern void EOS_Achievements_QueryDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryDefinitionsCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryPlayerAchievementsCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Achievements_UnlockAchievements(IntPtr handle, IntPtr options, IntPtr clientData, OnUnlockAchievementsCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement);

		[PreserveSig]
		internal static extern Result EOS_ActiveSession_CopyInfo(IntPtr handle, IntPtr options, ref IntPtr outActiveSessionInfo);

		[PreserveSig]
		internal static extern IntPtr EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo);

		[PreserveSig]
		internal static extern void EOS_ActiveSession_Release(IntPtr activeSessionHandle);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_AddExternalIntegrityCatalog(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyMessageToPeer(IntPtr handle, IntPtr options, IntPtr clientData, OnMessageToPeerCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyMessageToServer(IntPtr handle, IntPtr options, IntPtr clientData, OnMessageToServerCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyPeerActionRequired(IntPtr handle, IntPtr options, IntPtr clientData, OnPeerActionRequiredCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnPeerAuthStatusChangedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_BeginSession(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_EndSession(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_GetProtectMessageOutputLength(IntPtr handle, IntPtr options, ref uint outBufferSizeBytes);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_PollStatus(IntPtr handle, IntPtr options, ref AntiCheatClientViolationType outViolationType, IntPtr outMessage);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_ProtectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, ref uint outBytesWritten);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_ReceiveMessageFromPeer(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_ReceiveMessageFromServer(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_RegisterPeer(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyMessageToPeer(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyMessageToServer(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_UnprotectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, ref uint outBytesWritten);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_UnregisterPeer(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_AntiCheatServer_AddNotifyClientActionRequired(IntPtr handle, IntPtr options, IntPtr clientData, OnClientActionRequiredCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnClientAuthStatusChangedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_AntiCheatServer_AddNotifyMessageToClient(IntPtr handle, IntPtr options, IntPtr clientData, OnMessageToClientCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_BeginSession(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_EndSession(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_GetProtectMessageOutputLength(IntPtr handle, IntPtr options, ref uint outBufferSizeBytes);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogEvent(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogGameRoundEnd(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogGameRoundStart(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerDespawn(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerRevive(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerSpawn(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerTakeDamage(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerTick(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerUseAbility(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerUseWeapon(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_ProtectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, ref uint outBytesWritten);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_ReceiveMessageFromClient(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_RegisterClient(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_RegisterEvent(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_AntiCheatServer_RemoveNotifyClientActionRequired(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_AntiCheatServer_RemoveNotifyMessageToClient(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_SetClientDetails(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_SetClientNetworkState(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_SetGameSessionId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_UnprotectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, ref uint outBytesWritten);

		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_UnregisterClient(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Auth.OnLoginStatusChangedCallbackInternal notification);

		[PreserveSig]
		internal static extern Result EOS_Auth_CopyIdToken(IntPtr handle, IntPtr options, ref IntPtr outIdToken);

		[PreserveSig]
		internal static extern Result EOS_Auth_CopyUserAuthToken(IntPtr handle, IntPtr options, IntPtr localUserId, ref IntPtr outUserAuthToken);

		[PreserveSig]
		internal static extern void EOS_Auth_DeletePersistentAuth(IntPtr handle, IntPtr options, IntPtr clientData, OnDeletePersistentAuthCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index);

		[PreserveSig]
		internal static extern int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle);

		[PreserveSig]
		internal static extern LoginStatus EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId);

		[PreserveSig]
		internal static extern IntPtr EOS_Auth_GetMergedAccountByIndex(IntPtr handle, IntPtr localUserId, uint index);

		[PreserveSig]
		internal static extern uint EOS_Auth_GetMergedAccountsCount(IntPtr handle, IntPtr localUserId);

		[PreserveSig]
		internal static extern Result EOS_Auth_GetSelectedAccountId(IntPtr handle, IntPtr localUserId, ref IntPtr outSelectedAccountId);

		[PreserveSig]
		internal static extern void EOS_Auth_IdToken_Release(IntPtr idToken);

		[PreserveSig]
		internal static extern void EOS_Auth_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Auth.OnLinkAccountCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Auth_Login(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Auth.OnLoginCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Auth_Logout(IntPtr handle, IntPtr options, IntPtr clientData, OnLogoutCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Auth_QueryIdToken(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryIdTokenCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Auth_Token_Release(IntPtr authToken);

		[PreserveSig]
		internal static extern void EOS_Auth_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Auth.OnVerifyIdTokenCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Auth_VerifyUserAuth(IntPtr handle, IntPtr options, IntPtr clientData, OnVerifyUserAuthCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, ref uint inOutBufferLength);

		[PreserveSig]
		internal static extern ulong EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, IntPtr options, IntPtr clientData, OnAuthExpirationCallbackInternal notification);

		[PreserveSig]
		internal static extern ulong EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Connect.OnLoginStatusChangedCallbackInternal notification);

		[PreserveSig]
		internal static extern Result EOS_Connect_CopyIdToken(IntPtr handle, IntPtr options, ref IntPtr outIdToken);

		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserInfo(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

		[PreserveSig]
		internal static extern void EOS_Connect_CreateDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, OnCreateDeviceIdCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Connect.OnCreateUserCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_DeleteDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, OnDeleteDeviceIdCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo);

		[PreserveSig]
		internal static extern IntPtr EOS_Connect_GetExternalAccountMapping(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern IntPtr EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index);

		[PreserveSig]
		internal static extern int EOS_Connect_GetLoggedInUsersCount(IntPtr handle);

		[PreserveSig]
		internal static extern LoginStatus EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId);

		[PreserveSig]
		internal static extern uint EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_Connect_GetProductUserIdMapping(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern void EOS_Connect_IdToken_Release(IntPtr idToken);

		[PreserveSig]
		internal static extern void EOS_Connect_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Connect.OnLinkAccountCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_Login(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Connect.OnLoginCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_QueryExternalAccountMappings(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryExternalAccountMappingsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_QueryProductUserIdMappings(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryProductUserIdMappingsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Connect_TransferDeviceIdAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnTransferDeviceIdAccountCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_UnlinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnUnlinkAccountCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Connect_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Connect.OnVerifyIdTokenCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnCustomInviteAcceptedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnCustomInviteReceivedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern Result EOS_CustomInvites_FinalizeInvite(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteAccepted(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteReceived(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_CustomInvites_SendCustomInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnSendCustomInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_CustomInvites_SetCustomInvite(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern int EOS_EResult_IsOperationComplete(Result result);

		[PreserveSig]
		internal static extern IntPtr EOS_EResult_ToString(Result result);

		[PreserveSig]
		internal static extern void EOS_Ecom_CatalogItem_Release(IntPtr catalogItem);

		[PreserveSig]
		internal static extern void EOS_Ecom_CatalogOffer_Release(IntPtr catalogOffer);

		[PreserveSig]
		internal static extern void EOS_Ecom_CatalogRelease_Release(IntPtr catalogRelease);

		[PreserveSig]
		internal static extern void EOS_Ecom_Checkout(IntPtr handle, IntPtr options, IntPtr clientData, OnCheckoutCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyEntitlementById(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyEntitlementByIndex(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyEntitlementByNameAndIndex(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyItemById(IntPtr handle, IntPtr options, ref IntPtr outItem);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyItemImageInfoByIndex(IntPtr handle, IntPtr options, ref IntPtr outImageInfo);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyItemReleaseByIndex(IntPtr handle, IntPtr options, ref IntPtr outRelease);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferById(IntPtr handle, IntPtr options, ref IntPtr outOffer);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferByIndex(IntPtr handle, IntPtr options, ref IntPtr outOffer);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferImageInfoByIndex(IntPtr handle, IntPtr options, ref IntPtr outImageInfo);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferItemByIndex(IntPtr handle, IntPtr options, ref IntPtr outItem);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyTransactionById(IntPtr handle, IntPtr options, ref IntPtr outTransaction);

		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyTransactionByIndex(IntPtr handle, IntPtr options, ref IntPtr outTransaction);

		[PreserveSig]
		internal static extern void EOS_Ecom_Entitlement_Release(IntPtr entitlement);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetEntitlementsByNameCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetEntitlementsCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetItemImageInfoCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetItemReleaseCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetOfferCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetOfferImageInfoCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetOfferItemCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Ecom_GetTransactionCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Ecom_KeyImageInfo_Release(IntPtr keyImageInfo);

		[PreserveSig]
		internal static extern void EOS_Ecom_QueryEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryEntitlementsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Ecom_QueryOffers(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryOffersCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Ecom_QueryOwnership(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryOwnershipCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Ecom_QueryOwnershipToken(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryOwnershipTokenCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Ecom_RedeemEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, OnRedeemEntitlementsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

		[PreserveSig]
		internal static extern uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern void EOS_Ecom_Transaction_Release(IntPtr transaction);

		[PreserveSig]
		internal static extern IntPtr EOS_EpicAccountId_FromString(IntPtr accountIdString);

		[PreserveSig]
		internal static extern int EOS_EpicAccountId_IsValid(IntPtr accountId);

		[PreserveSig]
		internal static extern Result EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern void EOS_Friends_AcceptInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnAcceptInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_Friends_AddNotifyFriendsUpdate(IntPtr handle, IntPtr options, IntPtr clientData, OnFriendsUpdateCallbackInternal friendsUpdateHandler);

		[PreserveSig]
		internal static extern IntPtr EOS_Friends_GetFriendAtIndex(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern int EOS_Friends_GetFriendsCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern FriendsStatus EOS_Friends_GetStatus(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Friends_QueryFriends(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryFriendsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Friends_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Friends.OnRejectInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Friends_RemoveNotifyFriendsUpdate(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_Friends_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Friends.OnSendInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Initialize(IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_KWS_AddNotifyPermissionsUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnPermissionsUpdateReceivedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern Result EOS_KWS_CopyPermissionByIndex(IntPtr handle, IntPtr options, ref IntPtr outPermission);

		[PreserveSig]
		internal static extern void EOS_KWS_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.KWS.OnCreateUserCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_KWS_GetPermissionByKey(IntPtr handle, IntPtr options, ref KWSPermissionStatus outPermission);

		[PreserveSig]
		internal static extern int EOS_KWS_GetPermissionsCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_KWS_PermissionStatus_Release(IntPtr permissionStatus);

		[PreserveSig]
		internal static extern void EOS_KWS_QueryAgeGate(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryAgeGateCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_KWS_QueryPermissions(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryPermissionsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_KWS_RemoveNotifyPermissionsUpdateReceived(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_KWS_RequestPermissions(IntPtr handle, IntPtr options, IntPtr clientData, OnRequestPermissionsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_KWS_UpdateParentEmail(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateParentEmailCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByIndex(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardDefinition);

		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByLeaderboardId(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardDefinition);

		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByIndex(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardRecord);

		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByUserId(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardRecord);

		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByIndex(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardUserScore);

		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByUserId(IntPtr handle, IntPtr options, ref IntPtr outLeaderboardUserScore);

		[PreserveSig]
		internal static extern void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition);

		[PreserveSig]
		internal static extern uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Leaderboards_GetLeaderboardRecordCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_Leaderboards_GetLeaderboardUserScoreCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition);

		[PreserveSig]
		internal static extern void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord);

		[PreserveSig]
		internal static extern void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore);

		[PreserveSig]
		internal static extern void EOS_Leaderboards_QueryLeaderboardDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryLeaderboardDefinitionsCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Leaderboards_QueryLeaderboardRanks(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryLeaderboardRanksCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Leaderboards_QueryLeaderboardUserScores(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryLeaderboardUserScoresCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyAttributeByIndex(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyAttributeByKey(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyInfo(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsInfo);

		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByIndex(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByKey(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

		[PreserveSig]
		internal static extern uint EOS_LobbyDetails_GetAttributeCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern IntPtr EOS_LobbyDetails_GetLobbyOwner(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_LobbyDetails_GetMemberAttributeCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern IntPtr EOS_LobbyDetails_GetMemberByIndex(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_LobbyDetails_GetMemberCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_LobbyDetails_Info_Release(IntPtr lobbyDetailsInfo);

		[PreserveSig]
		internal static extern void EOS_LobbyDetails_Release(IntPtr lobbyHandle);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_AddAttribute(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_AddMemberAttribute(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_LobbyModification_Release(IntPtr lobbyModificationHandle);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_RemoveAttribute(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_RemoveMemberAttribute(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetBucketId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetInvitesAllowed(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetMaxMembers(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetPermissionLevel(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbySearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

		[PreserveSig]
		internal static extern void EOS_LobbySearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, LobbySearchOnFindCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern uint EOS_LobbySearch_GetSearchResultCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_LobbySearch_Release(IntPtr lobbySearchHandle);

		[PreserveSig]
		internal static extern Result EOS_LobbySearch_RemoveParameter(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetLobbyId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetMaxResults(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetParameter(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetTargetUserId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyJoinLobbyAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinLobbyAcceptedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyInviteAcceptedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyInviteReceivedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberStatusReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyMemberStatusReceivedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyMemberUpdateReceivedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyUpdateReceivedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyRTCRoomConnectionChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnRTCRoomConnectionChangedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern void EOS_Lobby_Attribute_Release(IntPtr lobbyAttribute);

		[PreserveSig]
		internal static extern Result EOS_Lobby_CopyLobbyDetailsHandle(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

		[PreserveSig]
		internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByInviteId(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

		[PreserveSig]
		internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByUiEventId(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

		[PreserveSig]
		internal static extern void EOS_Lobby_CreateLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnCreateLobbyCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Lobby_CreateLobbySearch(IntPtr handle, IntPtr options, ref IntPtr outLobbySearchHandle);

		[PreserveSig]
		internal static extern void EOS_Lobby_DestroyLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnDestroyLobbyCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern uint EOS_Lobby_GetInviteCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_Lobby_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern Result EOS_Lobby_GetRTCRoomName(IntPtr handle, IntPtr options, IntPtr outBuffer, ref uint inOutBufferLength);

		[PreserveSig]
		internal static extern Result EOS_Lobby_IsRTCRoomConnected(IntPtr handle, IntPtr options, ref int bOutIsConnected);

		[PreserveSig]
		internal static extern void EOS_Lobby_JoinLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinLobbyCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Lobby_KickMember(IntPtr handle, IntPtr options, IntPtr clientData, OnKickMemberCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Lobby_LeaveLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnLeaveLobbyCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Lobby_PromoteMember(IntPtr handle, IntPtr options, IntPtr clientData, OnPromoteMemberCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Lobby_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Lobby.OnQueryInvitesCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Lobby_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Lobby.OnRejectInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyJoinLobbyAccepted(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteAccepted(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteReceived(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberStatusReceived(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberUpdateReceived(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyUpdateReceived(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyRTCRoomConnectionChanged(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Lobby_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Lobby.OnSendInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Lobby_UpdateLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateLobbyCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Lobby_UpdateLobbyModification(IntPtr handle, IntPtr options, ref IntPtr outLobbyModificationHandle);

		[PreserveSig]
		internal static extern Result EOS_Logging_SetCallback(LogMessageFuncInternal callback);

		[PreserveSig]
		internal static extern Result EOS_Logging_SetLogLevel(LogCategory logCategory, LogLevel logLevel);

		[PreserveSig]
		internal static extern Result EOS_Metrics_BeginPlayerSession(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_Metrics_EndPlayerSession(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_Mods_CopyModInfo(IntPtr handle, IntPtr options, ref IntPtr outEnumeratedMods);

		[PreserveSig]
		internal static extern void EOS_Mods_EnumerateMods(IntPtr handle, IntPtr options, IntPtr clientData, OnEnumerateModsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Mods_InstallMod(IntPtr handle, IntPtr options, IntPtr clientData, OnInstallModCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Mods_ModInfo_Release(IntPtr modInfo);

		[PreserveSig]
		internal static extern void EOS_Mods_UninstallMod(IntPtr handle, IntPtr options, IntPtr clientData, OnUninstallModCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Mods_UpdateMod(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateModCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_P2P_AcceptConnection(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyIncomingPacketQueueFull(IntPtr handle, IntPtr options, IntPtr clientData, OnIncomingPacketQueueFullCallbackInternal incomingPacketQueueFullHandler);

		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyPeerConnectionClosed(IntPtr handle, IntPtr options, IntPtr clientData, OnRemoteConnectionClosedCallbackInternal connectionClosedHandler);

		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyPeerConnectionEstablished(IntPtr handle, IntPtr options, IntPtr clientData, OnPeerConnectionEstablishedCallbackInternal connectionEstablishedHandler);

		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyPeerConnectionRequest(IntPtr handle, IntPtr options, IntPtr clientData, OnIncomingConnectionRequestCallbackInternal connectionRequestHandler);

		[PreserveSig]
		internal static extern Result EOS_P2P_ClearPacketQueue(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_P2P_CloseConnection(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_P2P_CloseConnections(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_P2P_GetNATType(IntPtr handle, IntPtr options, ref NATType outNATType);

		[PreserveSig]
		internal static extern Result EOS_P2P_GetNextReceivedPacketSize(IntPtr handle, IntPtr options, ref uint outPacketSizeBytes);

		[PreserveSig]
		internal static extern Result EOS_P2P_GetPacketQueueInfo(IntPtr handle, IntPtr options, ref PacketQueueInfoInternal outPacketQueueInfo);

		[PreserveSig]
		internal static extern Result EOS_P2P_GetPortRange(IntPtr handle, IntPtr options, ref ushort outPort, ref ushort outNumAdditionalPortsToTry);

		[PreserveSig]
		internal static extern Result EOS_P2P_GetRelayControl(IntPtr handle, IntPtr options, ref RelayControl outRelayControl);

		[PreserveSig]
		internal static extern void EOS_P2P_QueryNATType(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryNATTypeCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_P2P_ReceivePacket(IntPtr handle, IntPtr options, ref IntPtr outPeerId, ref SocketIdInternal outSocketId, ref byte outChannel, IntPtr outData, ref uint outBytesWritten);

		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyIncomingPacketQueueFull(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyPeerConnectionClosed(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyPeerConnectionEstablished(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyPeerConnectionRequest(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern Result EOS_P2P_SendPacket(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_P2P_SetPacketQueueSize(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_P2P_SetPortRange(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_P2P_SetRelayControl(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_Platform_CheckForLauncherAndRestart(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_Create(IntPtr options);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAchievementsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_Platform_GetActiveCountryCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern Result EOS_Platform_GetActiveLocaleCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAntiCheatClientInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAntiCheatServerInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAuthInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetConnectInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetCustomInvitesInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetEcomInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetFriendsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetKWSInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetLeaderboardsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetLobbyInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetMetricsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetModsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_Platform_GetOverrideCountryCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern Result EOS_Platform_GetOverrideLocaleCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetP2PInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetPlayerDataStorageInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetPresenceInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetProgressionSnapshotInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetRTCAdminInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetRTCInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetReportsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetSanctionsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetSessionsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetStatsInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetTitleStorageInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetUIInterface(IntPtr handle);

		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetUserInfoInterface(IntPtr handle);

		[PreserveSig]
		internal static extern void EOS_Platform_Release(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_Platform_SetOverrideCountryCode(IntPtr handle, IntPtr newCountryCode);

		[PreserveSig]
		internal static extern Result EOS_Platform_SetOverrideLocaleCode(IntPtr handle, IntPtr newLocaleCode);

		[PreserveSig]
		internal static extern void EOS_Platform_Tick(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorageFileTransferRequest_CancelRequest(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorageFileTransferRequest_GetFileRequestState(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength);

		[PreserveSig]
		internal static extern void EOS_PlayerDataStorageFileTransferRequest_Release(IntPtr playerDataStorageFileTransferHandle);

		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr copyFileMetadataOptions, ref IntPtr outMetadata);

		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr copyFileMetadataOptions, ref IntPtr outMetadata);

		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnDeleteCacheCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, IntPtr deleteOptions, IntPtr clientData, OnDeleteFileCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, IntPtr duplicateOptions, IntPtr clientData, OnDuplicateFileCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata);

		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, IntPtr getFileMetadataCountOptions, ref int outFileMetadataCount);

		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_QueryFile(IntPtr handle, IntPtr queryFileOptions, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnQueryFileCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, IntPtr queryFileListOptions, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnQueryFileListCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, IntPtr readOptions, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnReadFileCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, IntPtr writeOptions, IntPtr clientData, OnWriteFileCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern Result EOS_PresenceModification_DeleteData(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_PresenceModification_Release(IntPtr presenceModificationHandle);

		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetData(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetJoinInfo(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetRawRichText(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetStatus(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinGameAcceptedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnPresenceChangedCallbackInternal notificationHandler);

		[PreserveSig]
		internal static extern Result EOS_Presence_CopyPresence(IntPtr handle, IntPtr options, ref IntPtr outPresence);

		[PreserveSig]
		internal static extern Result EOS_Presence_CreatePresenceModification(IntPtr handle, IntPtr options, ref IntPtr outPresenceModificationHandle);

		[PreserveSig]
		internal static extern Result EOS_Presence_GetJoinInfo(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern int EOS_Presence_HasPresence(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Presence_Info_Release(IntPtr presenceInfo);

		[PreserveSig]
		internal static extern void EOS_Presence_QueryPresence(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryPresenceCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_Presence_SetPresence(IntPtr handle, IntPtr options, IntPtr clientData, SetPresenceCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern IntPtr EOS_ProductUserId_FromString(IntPtr productUserIdString);

		[PreserveSig]
		internal static extern int EOS_ProductUserId_IsValid(IntPtr accountId);

		[PreserveSig]
		internal static extern Result EOS_ProductUserId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern Result EOS_ProgressionSnapshot_AddProgression(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_ProgressionSnapshot_BeginSnapshot(IntPtr handle, IntPtr options, ref uint outSnapshotId);

		[PreserveSig]
		internal static extern void EOS_ProgressionSnapshot_DeleteSnapshot(IntPtr handle, IntPtr options, IntPtr clientData, OnDeleteSnapshotCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_ProgressionSnapshot_EndSnapshot(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_ProgressionSnapshot_SubmitSnapshot(IntPtr handle, IntPtr options, IntPtr clientData, OnSubmitSnapshotCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_RTCAdmin_CopyUserTokenByIndex(IntPtr handle, IntPtr options, ref IntPtr outUserToken);

		[PreserveSig]
		internal static extern Result EOS_RTCAdmin_CopyUserTokenByUserId(IntPtr handle, IntPtr options, ref IntPtr outUserToken);

		[PreserveSig]
		internal static extern void EOS_RTCAdmin_Kick(IntPtr handle, IntPtr options, IntPtr clientData, OnKickCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_RTCAdmin_QueryJoinRoomToken(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryJoinRoomTokenCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_RTCAdmin_SetParticipantHardMute(IntPtr handle, IntPtr options, IntPtr clientData, OnSetParticipantHardMuteCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_RTCAdmin_UserToken_Release(IntPtr userToken);

		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioBeforeRender(IntPtr handle, IntPtr options, IntPtr clientData, OnAudioBeforeRenderCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioBeforeSend(IntPtr handle, IntPtr options, IntPtr clientData, OnAudioBeforeSendCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioDevicesChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnAudioDevicesChangedCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioInputState(IntPtr handle, IntPtr options, IntPtr clientData, OnAudioInputStateCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioOutputState(IntPtr handle, IntPtr options, IntPtr clientData, OnAudioOutputStateCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyParticipantUpdated(IntPtr handle, IntPtr options, IntPtr clientData, OnParticipantUpdatedCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern IntPtr EOS_RTCAudio_GetAudioInputDeviceByIndex(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_RTCAudio_GetAudioInputDevicesCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern IntPtr EOS_RTCAudio_GetAudioOutputDeviceByIndex(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern uint EOS_RTCAudio_GetAudioOutputDevicesCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_RTCAudio_RegisterPlatformAudioUser(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioBeforeRender(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioBeforeSend(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioDevicesChanged(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioInputState(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioOutputState(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyParticipantUpdated(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern Result EOS_RTCAudio_SendAudio(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_RTCAudio_SetAudioInputSettings(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_RTCAudio_SetAudioOutputSettings(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_RTCAudio_UnregisterPlatformAudioUser(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_UpdateReceiving(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateReceivingCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_RTCAudio_UpdateSending(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateSendingCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_RTC_AddNotifyDisconnected(IntPtr handle, IntPtr options, IntPtr clientData, OnDisconnectedCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern ulong EOS_RTC_AddNotifyParticipantStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnParticipantStatusChangedCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_RTC_BlockParticipant(IntPtr handle, IntPtr options, IntPtr clientData, OnBlockParticipantCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern IntPtr EOS_RTC_GetAudioInterface(IntPtr handle);

		[PreserveSig]
		internal static extern void EOS_RTC_JoinRoom(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinRoomCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_RTC_LeaveRoom(IntPtr handle, IntPtr options, IntPtr clientData, OnLeaveRoomCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_RTC_RemoveNotifyDisconnected(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern void EOS_RTC_RemoveNotifyParticipantStatusChanged(IntPtr handle, ulong notificationId);

		[PreserveSig]
		internal static extern Result EOS_RTC_SetRoomSetting(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_RTC_SetSetting(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Reports_SendPlayerBehaviorReport(IntPtr handle, IntPtr options, IntPtr clientData, OnSendPlayerBehaviorReportCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Sanctions_CopyPlayerSanctionByIndex(IntPtr handle, IntPtr options, ref IntPtr outSanction);

		[PreserveSig]
		internal static extern uint EOS_Sanctions_GetPlayerSanctionCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Sanctions_PlayerSanction_Release(IntPtr sanction);

		[PreserveSig]
		internal static extern void EOS_Sanctions_QueryActivePlayerSanctions(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryActivePlayerSanctionsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute);

		[PreserveSig]
		internal static extern Result EOS_SessionDetails_CopyInfo(IntPtr handle, IntPtr options, ref IntPtr outSessionInfo);

		[PreserveSig]
		internal static extern Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, IntPtr options, ref IntPtr outSessionAttribute);

		[PreserveSig]
		internal static extern Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, IntPtr options, ref IntPtr outSessionAttribute);

		[PreserveSig]
		internal static extern uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_SessionDetails_Info_Release(IntPtr sessionInfo);

		[PreserveSig]
		internal static extern void EOS_SessionDetails_Release(IntPtr sessionHandle);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_AddAttribute(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_SessionModification_Release(IntPtr sessionModificationHandle);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_RemoveAttribute(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetBucketId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetHostAddress(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

		[PreserveSig]
		internal static extern void EOS_SessionSearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, SessionSearchOnFindCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_SessionSearch_Release(IntPtr sessionSearchHandle);

		[PreserveSig]
		internal static extern Result EOS_SessionSearch_RemoveParameter(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetMaxResults(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetParameter(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetSessionId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinSessionAcceptedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnSessionInviteAcceptedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnSessionInviteReceivedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern Result EOS_Sessions_CopyActiveSessionHandle(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

		[PreserveSig]
		internal static extern Result EOS_Sessions_CopySessionHandleByInviteId(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

		[PreserveSig]
		internal static extern Result EOS_Sessions_CopySessionHandleByUiEventId(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

		[PreserveSig]
		internal static extern Result EOS_Sessions_CopySessionHandleForPresence(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

		[PreserveSig]
		internal static extern Result EOS_Sessions_CreateSessionModification(IntPtr handle, IntPtr options, ref IntPtr outSessionModificationHandle);

		[PreserveSig]
		internal static extern Result EOS_Sessions_CreateSessionSearch(IntPtr handle, IntPtr options, ref IntPtr outSessionSearchHandle);

		[PreserveSig]
		internal static extern void EOS_Sessions_DestroySession(IntPtr handle, IntPtr options, IntPtr clientData, OnDestroySessionCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Sessions_DumpSessionState(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Sessions_EndSession(IntPtr handle, IntPtr options, IntPtr clientData, OnEndSessionCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern uint EOS_Sessions_GetInviteCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_Sessions_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

		[PreserveSig]
		internal static extern Result EOS_Sessions_IsUserInSession(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Sessions_JoinSession(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinSessionCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Sessions_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Sessions.OnQueryInvitesCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Sessions_RegisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, OnRegisterPlayersCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Sessions_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Sessions.OnRejectInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifyJoinSessionAccepted(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifySessionInviteAccepted(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifySessionInviteReceived(IntPtr handle, ulong inId);

		[PreserveSig]
		internal static extern void EOS_Sessions_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.Sessions.OnSendInviteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Sessions_StartSession(IntPtr handle, IntPtr options, IntPtr clientData, OnStartSessionCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Sessions_UnregisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, OnUnregisterPlayersCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Sessions_UpdateSession(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateSessionCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_Sessions_UpdateSessionModification(IntPtr handle, IntPtr options, ref IntPtr outSessionModificationHandle);

		[PreserveSig]
		internal static extern Result EOS_Shutdown();

		[PreserveSig]
		internal static extern Result EOS_Stats_CopyStatByIndex(IntPtr handle, IntPtr options, ref IntPtr outStat);

		[PreserveSig]
		internal static extern Result EOS_Stats_CopyStatByName(IntPtr handle, IntPtr options, ref IntPtr outStat);

		[PreserveSig]
		internal static extern uint EOS_Stats_GetStatsCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_Stats_IngestStat(IntPtr handle, IntPtr options, IntPtr clientData, OnIngestStatCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Stats_QueryStats(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryStatsCompleteCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_Stats_Stat_Release(IntPtr stat);

		[PreserveSig]
		internal static extern Result EOS_TitleStorageFileTransferRequest_CancelRequest(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_TitleStorageFileTransferRequest_GetFileRequestState(IntPtr handle);

		[PreserveSig]
		internal static extern Result EOS_TitleStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength);

		[PreserveSig]
		internal static extern void EOS_TitleStorageFileTransferRequest_Release(IntPtr titleStorageFileTransferHandle);

		[PreserveSig]
		internal static extern Result EOS_TitleStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr options, ref IntPtr outMetadata);

		[PreserveSig]
		internal static extern Result EOS_TitleStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr options, ref IntPtr outMetadata);

		[PreserveSig]
		internal static extern Result EOS_TitleStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnDeleteCacheCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata);

		[PreserveSig]
		internal static extern uint EOS_TitleStorage_GetFileMetadataCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_TitleStorage_QueryFile(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnQueryFileCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern void EOS_TitleStorage_QueryFileList(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnQueryFileListCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, IntPtr options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnReadFileCompleteCallbackInternal completionCallback);

		[PreserveSig]
		internal static extern Result EOS_UI_AcknowledgeEventId(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern ulong EOS_UI_AddNotifyDisplaySettingsUpdated(IntPtr handle, IntPtr options, IntPtr clientData, OnDisplaySettingsUpdatedCallbackInternal notificationFn);

		[PreserveSig]
		internal static extern int EOS_UI_GetFriendsVisible(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern NotificationLocation EOS_UI_GetNotificationLocationPreference(IntPtr handle);

		[PreserveSig]
		internal static extern KeyCombination EOS_UI_GetToggleFriendsKey(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_UI_HideFriends(IntPtr handle, IntPtr options, IntPtr clientData, OnHideFriendsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern int EOS_UI_IsValidKeyCombination(IntPtr handle, KeyCombination keyCombination);

		[PreserveSig]
		internal static extern void EOS_UI_RemoveNotifyDisplaySettingsUpdated(IntPtr handle, ulong id);

		[PreserveSig]
		internal static extern Result EOS_UI_SetDisplayPreference(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern Result EOS_UI_SetToggleFriendsKey(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_UI_ShowFriends(IntPtr handle, IntPtr options, IntPtr clientData, OnShowFriendsCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountId(IntPtr handle, IntPtr options, ref IntPtr outExternalUserInfo);

		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountType(IntPtr handle, IntPtr options, ref IntPtr outExternalUserInfo);

		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyExternalUserInfoByIndex(IntPtr handle, IntPtr options, ref IntPtr outExternalUserInfo);

		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyUserInfo(IntPtr handle, IntPtr options, ref IntPtr outUserInfo);

		[PreserveSig]
		internal static extern void EOS_UserInfo_ExternalUserInfo_Release(IntPtr externalUserInfo);

		[PreserveSig]
		internal static extern uint EOS_UserInfo_GetExternalUserInfoCount(IntPtr handle, IntPtr options);

		[PreserveSig]
		internal static extern void EOS_UserInfo_QueryUserInfo(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryUserInfoCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_UserInfo_QueryUserInfoByDisplayName(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryUserInfoByDisplayNameCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_UserInfo_QueryUserInfoByExternalAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryUserInfoByExternalAccountCallbackInternal completionDelegate);

		[PreserveSig]
		internal static extern void EOS_UserInfo_Release(IntPtr userInfo);
	}
}
