using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	internal class GalaxyInstancePINVOKE
	{
		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			static SWIGExceptionHelper()
			{
			}

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacks_GalaxyInstance(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacksArgument_GalaxyInstance(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			private static void SetPendingApplicationException(string message)
			{
			}

			private static void SetPendingArithmeticException(string message)
			{
			}

			private static void SetPendingDivideByZeroException(string message)
			{
			}

			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			private static void SetPendingInvalidCastException(string message)
			{
			}

			private static void SetPendingInvalidOperationException(string message)
			{
			}

			private static void SetPendingIOException(string message)
			{
			}

			private static void SetPendingNullReferenceException(string message)
			{
			}

			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			private static void SetPendingOverflowException(string message)
			{
			}

			private static void SetPendingSystemException(string message)
			{
			}

			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			public static bool Pending => false;

			public static void Set(Exception e)
			{
			}

			public static Exception Retrieve()
			{
				return null;
			}
		}

		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			static SWIGStringHelper()
			{
			}

			[PreserveSig]
			public static extern void SWIGRegisterStringCallback_GalaxyInstance(SWIGStringDelegate stringDelegate);

			private static string CreateString(string cString)
			{
				return null;
			}
		}

		public class UTF8Marshaler : ICustomMarshaler
		{
			private static UTF8Marshaler static_instance;

			public IntPtr MarshalManagedToNative(object managedObj)
			{
				return (IntPtr)0;
			}

			public object MarshalNativeToManaged(IntPtr pNativeData)
			{
				return null;
			}

			public void CleanUpNativeData(IntPtr pNativeData)
			{
			}

			public void CleanUpManagedData(object managedObj)
			{
			}

			public int GetNativeDataSize()
			{
				return 0;
			}

			public static ICustomMarshaler GetInstance(string cookie)
			{
				return null;
			}
		}

		protected static SWIGExceptionHelper swigExceptionHelper;

		protected static SWIGStringHelper swigStringHelper;

		static GalaxyInstancePINVOKE()
		{
		}

		[PreserveSig]
		public static extern void delete_IError(HandleRef jarg1);

		[PreserveSig]
		public static extern string IError_GetName(HandleRef jarg1);

		[PreserveSig]
		public static extern string IError_GetMsg(HandleRef jarg1);

		[PreserveSig]
		public static extern int IError_GetErrorType(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_IUnauthorizedAccessError(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_IInvalidArgumentError(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_IInvalidStateError(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_IRuntimeError(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr GetError();

		[PreserveSig]
		public static extern void delete_IGalaxyListener(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_IGalaxyListener();

		[PreserveSig]
		public static extern void delete_IListenerRegistrar(HandleRef jarg1);

		[PreserveSig]
		public static extern void IListenerRegistrar_Register(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IListenerRegistrar_Unregister(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern IntPtr ListenerRegistrar();

		[PreserveSig]
		public static extern IntPtr GameServerListenerRegistrar();

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerOverlayVisibilityChange_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerOverlayVisibilityChange();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerOverlayVisibilityChange(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerOverlayInitializationStateChange_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerOverlayInitializationStateChange();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerOverlayInitializationStateChange(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerGogServicesConnectionState_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerGogServicesConnectionState();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerGogServicesConnectionState(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerOperationalStateChange_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerOperationalStateChange();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerOperationalStateChange(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerAuth_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerAuth();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerAuth(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerOtherSessionStart_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerOtherSessionStart();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerOtherSessionStart(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerUserData_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerUserData();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerUserData(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerSpecificUserData_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerSpecificUserData();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerSpecificUserData(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerEncryptedAppTicket_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerEncryptedAppTicket();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerEncryptedAppTicket(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerAccessToken_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerAccessToken();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerAccessToken(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyList_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyList();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyList(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyCreated_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyCreated();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyCreated(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyEntered_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyEntered();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyEntered(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyLeft_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyLeft();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyLeft(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyData_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyData();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyData(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyDataUpdate_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyDataUpdate();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyDataUpdate(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyMemberDataUpdate_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyMemberDataUpdate();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyMemberDataUpdate(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyDataRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyDataRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyDataRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyMemberState_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyMemberState();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyMemberState(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyOwnerChange_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyOwnerChange();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyOwnerChange(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLobbyMessage_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLobbyMessage();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLobbyMessage(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerUserStatsAndAchievementsRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerUserStatsAndAchievementsRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerUserStatsAndAchievementsRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerStatsAndAchievementsStore_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerStatsAndAchievementsStore();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerStatsAndAchievementsStore(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerAchievementChange_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerAchievementChange();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerAchievementChange(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLeaderboardsRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLeaderboardsRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLeaderboardsRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLeaderboardEntriesRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLeaderboardEntriesRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLeaderboardEntriesRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLeaderboardScoreUpdate_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLeaderboardScoreUpdate();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLeaderboardScoreUpdate(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerLeaderboardRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerLeaderboardRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerLeaderboardRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerUserTimePlayedRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerUserTimePlayedRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerUserTimePlayedRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFileShare_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFileShare();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFileShare(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerSharedFileDownload_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerSharedFileDownload();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerSharedFileDownload(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerConnectionOpen_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerConnectionOpen();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerConnectionOpen(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerConnectionClose_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerConnectionClose();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerConnectionClose(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerConnectionData_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerConnectionData();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerConnectionData(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerNetworking_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerNetworking();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerNetworking(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerNatTypeDetection_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerNatTypeDetection();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerNatTypeDetection(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerPersonaDataChanged_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerPersonaDataChanged();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerPersonaDataChanged(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerUserInformationRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerUserInformationRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerUserInformationRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFriendList_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFriendList();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFriendList(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFriendInvitationSend_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFriendInvitationSend();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFriendInvitationSend(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFriendInvitationListRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFriendInvitationListRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFriendInvitationListRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerSentFriendInvitationListRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerSentFriendInvitationListRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerSentFriendInvitationListRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFriendInvitation_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFriendInvitation();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFriendInvitation(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFriendInvitationRespondTo_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFriendInvitationRespondTo();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFriendInvitationRespondTo(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFriendAdd_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFriendAdd();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFriendAdd(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerFriendDelete_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerFriendDelete();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerFriendDelete(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerRichPresenceChange_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerRichPresenceChange();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerRichPresenceChange(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerRichPresence_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerRichPresence();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerRichPresence(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerRichPresenceRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerRichPresenceRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerRichPresenceRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerGameJoinRequested_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerGameJoinRequested();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerGameJoinRequested(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerGameInvitationReceived_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerGameInvitationReceived();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerGameInvitationReceived(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerSendInvitation_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerSendInvitation();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerSendInvitation(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerNotification_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerNotification();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerNotification(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerUserFind_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerUserFind();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerUserFind(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerChatRoomWithUserRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerChatRoomWithUserRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerChatRoomWithUserRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerChatRoomMessagesRetrieve_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerChatRoomMessagesRetrieve();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerChatRoomMessagesRetrieve(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerChatRoomMessageSend_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerChatRoomMessageSend();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerChatRoomMessageSend(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerChatRoomMessages_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerChatRoomMessages();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerChatRoomMessages(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerTelemetryEventSend_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerTelemetryEventSend();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerTelemetryEventSend(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerCloudStorageGetFileList_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerCloudStorageGetFileList();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerCloudStorageGetFileList(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerCloudStorageGetFile_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerCloudStorageGetFile();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerCloudStorageGetFile(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerCloudStoragePutFile_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerCloudStoragePutFile();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerCloudStoragePutFile(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerCloudStorageDeleteFile_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerCloudStorageDeleteFile();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerCloudStorageDeleteFile(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyTypeAwareListenerIsDlcOwned_GetListenerType();

		[PreserveSig]
		public static extern IntPtr new_GalaxyTypeAwareListenerIsDlcOwned();

		[PreserveSig]
		public static extern void delete_GalaxyTypeAwareListenerIsDlcOwned(HandleRef jarg1);

		[PreserveSig]
		public static extern void IIsDlcOwnedListener_OnDlcCheckSuccess(HandleRef jarg1, ulong jarg2, bool jarg3);

		[PreserveSig]
		public static extern void IIsDlcOwnedListener_OnDlcCheckFailure(HandleRef jarg1, ulong jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IIsDlcOwnedListener();

		[PreserveSig]
		public static extern void delete_IIsDlcOwnedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IIsDlcOwnedListener_director_connect(HandleRef jarg1, IIsDlcOwnedListener.SwigDelegateIIsDlcOwnedListener_0 delegate0, IIsDlcOwnedListener.SwigDelegateIIsDlcOwnedListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_IApps(HandleRef jarg1);

		[PreserveSig]
		public static extern bool IApps_IsDlcInstalled(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern void IApps_IsDlcOwned(HandleRef jarg1, ulong jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern string IApps_GetCurrentGameLanguage__SWIG_0(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern string IApps_GetCurrentGameLanguage__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IApps_GetCurrentGameLanguageCopy__SWIG_0(HandleRef jarg1, byte[] jarg2, uint jarg3, ulong jarg4);

		[PreserveSig]
		public static extern void IApps_GetCurrentGameLanguageCopy__SWIG_1(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern string IApps_GetCurrentGameLanguageCode__SWIG_0(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern string IApps_GetCurrentGameLanguageCode__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IApps_GetCurrentGameLanguageCodeCopy__SWIG_0(HandleRef jarg1, byte[] jarg2, uint jarg3, ulong jarg4);

		[PreserveSig]
		public static extern void IApps_GetCurrentGameLanguageCodeCopy__SWIG_1(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern void IOverlayVisibilityChangeListener_OnOverlayVisibilityChanged(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		public static extern IntPtr new_IOverlayVisibilityChangeListener();

		[PreserveSig]
		public static extern void delete_IOverlayVisibilityChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IOverlayVisibilityChangeListener_director_connect(HandleRef jarg1, IOverlayVisibilityChangeListener.SwigDelegateIOverlayVisibilityChangeListener_0 delegate0);

		[PreserveSig]
		public static extern void IOverlayInitializationStateChangeListener_OnOverlayStateChanged(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_IOverlayInitializationStateChangeListener();

		[PreserveSig]
		public static extern void delete_IOverlayInitializationStateChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IOverlayInitializationStateChangeListener_director_connect(HandleRef jarg1, IOverlayInitializationStateChangeListener.SwigDelegateIOverlayInitializationStateChangeListener_0 delegate0);

		[PreserveSig]
		public static extern void INotificationListener_OnNotificationReceived(HandleRef jarg1, ulong jarg2, uint jarg3, uint jarg4);

		[PreserveSig]
		public static extern IntPtr new_INotificationListener();

		[PreserveSig]
		public static extern void delete_INotificationListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void INotificationListener_director_connect(HandleRef jarg1, INotificationListener.SwigDelegateINotificationListener_0 delegate0);

		[PreserveSig]
		public static extern void IGogServicesConnectionStateListener_OnConnectionStateChange(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_IGogServicesConnectionStateListener();

		[PreserveSig]
		public static extern void delete_IGogServicesConnectionStateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IGogServicesConnectionStateListener_director_connect(HandleRef jarg1, IGogServicesConnectionStateListener.SwigDelegateIGogServicesConnectionStateListener_0 delegate0);

		[PreserveSig]
		public static extern void delete_IUtils(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUtils_GetImageSize(HandleRef jarg1, uint jarg2, ref int jarg3, ref int jarg4);

		[PreserveSig]
		public static extern void IUtils_GetImageRGBA(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IUtils_RegisterForNotification(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern uint IUtils_GetNotification(HandleRef jarg1, ulong jarg2, ref bool jarg3, byte[] jarg4, uint jarg5, byte[] jarg6, uint jarg7);

		[PreserveSig]
		public static extern void IUtils_ShowOverlayWithWebPage(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern bool IUtils_IsOverlayVisible(HandleRef jarg1);

		[PreserveSig]
		public static extern int IUtils_GetOverlayState(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUtils_DisableOverlayPopups(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern int IUtils_GetGogServicesConnectionState(HandleRef jarg1);

		[PreserveSig]
		public static extern void IAuthListener_OnAuthSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void IAuthListener_OnAuthFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void IAuthListener_OnAuthLost(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_IAuthListener();

		[PreserveSig]
		public static extern void delete_IAuthListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IAuthListener_director_connect(HandleRef jarg1, IAuthListener.SwigDelegateIAuthListener_0 delegate0, IAuthListener.SwigDelegateIAuthListener_1 delegate1, IAuthListener.SwigDelegateIAuthListener_2 delegate2);

		[PreserveSig]
		public static extern void IOtherSessionStartListener_OnOtherSessionStarted(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_IOtherSessionStartListener();

		[PreserveSig]
		public static extern void delete_IOtherSessionStartListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IOtherSessionStartListener_director_connect(HandleRef jarg1, IOtherSessionStartListener.SwigDelegateIOtherSessionStartListener_0 delegate0);

		[PreserveSig]
		public static extern void IOperationalStateChangeListener_OnOperationalStateChanged(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern IntPtr new_IOperationalStateChangeListener();

		[PreserveSig]
		public static extern void delete_IOperationalStateChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IOperationalStateChangeListener_director_connect(HandleRef jarg1, IOperationalStateChangeListener.SwigDelegateIOperationalStateChangeListener_0 delegate0);

		[PreserveSig]
		public static extern void IUserDataListener_OnUserDataUpdated(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_IUserDataListener();

		[PreserveSig]
		public static extern void delete_IUserDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUserDataListener_director_connect(HandleRef jarg1, IUserDataListener.SwigDelegateIUserDataListener_0 delegate0);

		[PreserveSig]
		public static extern void ISpecificUserDataListener_OnSpecificUserDataUpdated(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr new_ISpecificUserDataListener();

		[PreserveSig]
		public static extern void delete_ISpecificUserDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ISpecificUserDataListener_director_connect(HandleRef jarg1, ISpecificUserDataListener.SwigDelegateISpecificUserDataListener_0 delegate0);

		[PreserveSig]
		public static extern void IEncryptedAppTicketListener_OnEncryptedAppTicketRetrieveSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void IEncryptedAppTicketListener_OnEncryptedAppTicketRetrieveFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_IEncryptedAppTicketListener();

		[PreserveSig]
		public static extern void delete_IEncryptedAppTicketListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IEncryptedAppTicketListener_director_connect(HandleRef jarg1, IEncryptedAppTicketListener.SwigDelegateIEncryptedAppTicketListener_0 delegate0, IEncryptedAppTicketListener.SwigDelegateIEncryptedAppTicketListener_1 delegate1);

		[PreserveSig]
		public static extern void IAccessTokenListener_OnAccessTokenChanged(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_IAccessTokenListener();

		[PreserveSig]
		public static extern void delete_IAccessTokenListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IAccessTokenListener_director_connect(HandleRef jarg1, IAccessTokenListener.SwigDelegateIAccessTokenListener_0 delegate0);

		[PreserveSig]
		public static extern void IPlayFabCreateOpenIDConnectionListener_OnPlayFabCreateOpenIDConnectionSuccess(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		public static extern void IPlayFabCreateOpenIDConnectionListener_OnPlayFabCreateOpenIDConnectionFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void delete_IPlayFabCreateOpenIDConnectionListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IPlayFabLoginWithOpenIDConnectListener_OnPlayFabLoginWithOpenIDConnectSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void IPlayFabLoginWithOpenIDConnectListener_OnPlayFabLoginWithOpenIDConnectFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void delete_IPlayFabLoginWithOpenIDConnectListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_IUser(HandleRef jarg1);

		[PreserveSig]
		public static extern bool IUser_SignedIn(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr IUser_GetGalaxyID(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_SignInCredentials__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IUser_SignInCredentials__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void IUser_SignInToken__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUser_SignInToken__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IUser_SignInLauncher__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUser_SignInLauncher__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_SignInSteam__SWIG_0(HandleRef jarg1, byte[] jarg2, uint jarg3, string jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IUser_SignInSteam__SWIG_1(HandleRef jarg1, byte[] jarg2, uint jarg3, string jarg4);

		[PreserveSig]
		public static extern void IUser_SignInGalaxy__SWIG_0(HandleRef jarg1, bool jarg2, uint jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IUser_SignInGalaxy__SWIG_1(HandleRef jarg1, bool jarg2, uint jarg3);

		[PreserveSig]
		public static extern void IUser_SignInGalaxy__SWIG_2(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		public static extern void IUser_SignInGalaxy__SWIG_3(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_SignInPS4__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUser_SignInPS4__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IUser_SignInXB1__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUser_SignInXB1__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IUser_SignInXbox__SWIG_0(HandleRef jarg1, ulong jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUser_SignInXbox__SWIG_1(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern void IUser_SignInXBLive__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, string jarg4, string jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern void IUser_SignInXBLive__SWIG_1(HandleRef jarg1, string jarg2, string jarg3, string jarg4, string jarg5);

		[PreserveSig]
		public static extern void IUser_SignInAnonymous__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUser_SignInAnonymous__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_SignInAnonymousTelemetry__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUser_SignInAnonymousTelemetry__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_SignInServerKey__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUser_SignInServerKey__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IUser_SignInAuthorizationCode__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IUser_SignInAuthorizationCode__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void IUser_SignOut(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_RequestUserData__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUser_RequestUserData__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUser_RequestUserData__SWIG_2(HandleRef jarg1);

		[PreserveSig]
		public static extern bool IUser_IsUserDataAvailable__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool IUser_IsUserDataAvailable__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern string IUser_GetUserData__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern string IUser_GetUserData__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IUser_GetUserDataCopy__SWIG_0(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IUser_GetUserDataCopy__SWIG_1(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IUser_SetUserData__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IUser_SetUserData__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern uint IUser_GetUserDataCount__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint IUser_GetUserDataCount__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern bool IUser_GetUserDataByIndex__SWIG_0(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4, byte[] jarg5, uint jarg6, HandleRef jarg7);

		[PreserveSig]
		public static extern bool IUser_GetUserDataByIndex__SWIG_1(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4, byte[] jarg5, uint jarg6);

		[PreserveSig]
		public static extern void IUser_DeleteUserData__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUser_DeleteUserData__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern bool IUser_IsLoggedOn(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_RequestEncryptedAppTicket__SWIG_0(HandleRef jarg1, byte[] jarg2, uint jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IUser_RequestEncryptedAppTicket__SWIG_1(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern void IUser_GetEncryptedAppTicket(HandleRef jarg1, byte[] jarg2, uint jarg3, ref uint jarg4);

		[PreserveSig]
		public static extern void IUser_CreateOpenIDConnection__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, string jarg4, bool jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern void IUser_CreateOpenIDConnection__SWIG_1(HandleRef jarg1, string jarg2, string jarg3, string jarg4, bool jarg5);

		[PreserveSig]
		public static extern void IUser_CreateOpenIDConnection__SWIG_2(HandleRef jarg1, string jarg2, string jarg3, string jarg4);

		[PreserveSig]
		public static extern void IUser_LoginWithOpenIDConnect__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, string jarg4, bool jarg5, string jarg6, string jarg7, HandleRef jarg8);

		[PreserveSig]
		public static extern void IUser_LoginWithOpenIDConnect__SWIG_1(HandleRef jarg1, string jarg2, string jarg3, string jarg4, bool jarg5, string jarg6, string jarg7);

		[PreserveSig]
		public static extern void IUser_LoginWithOpenIDConnect__SWIG_2(HandleRef jarg1, string jarg2, string jarg3, string jarg4, bool jarg5, string jarg6);

		[PreserveSig]
		public static extern void IUser_LoginWithOpenIDConnect__SWIG_3(HandleRef jarg1, string jarg2, string jarg3, string jarg4, bool jarg5);

		[PreserveSig]
		public static extern void IUser_LoginWithOpenIDConnect__SWIG_4(HandleRef jarg1, string jarg2, string jarg3, string jarg4);

		[PreserveSig]
		public static extern ulong IUser_GetSessionID(HandleRef jarg1);

		[PreserveSig]
		public static extern string IUser_GetAccessToken(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_GetAccessTokenCopy(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern string IUser_GetRefreshToken(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_GetRefreshTokenCopy(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern string IUser_GetIDToken(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUser_GetIDTokenCopy(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern bool IUser_ReportInvalidAccessToken__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern bool IUser_ReportInvalidAccessToken__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void delete_ILogger(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILogger_Trace(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ILogger_Debug(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ILogger_Info(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ILogger_Warning(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ILogger_Error(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ILogger_Fatal(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IPersonaDataChangedListener_OnPersonaDataChanged(HandleRef jarg1, HandleRef jarg2, uint jarg3);

		[PreserveSig]
		public static extern IntPtr new_IPersonaDataChangedListener();

		[PreserveSig]
		public static extern void delete_IPersonaDataChangedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IPersonaDataChangedListener_director_connect(HandleRef jarg1, IPersonaDataChangedListener.SwigDelegateIPersonaDataChangedListener_0 delegate0);

		[PreserveSig]
		public static extern void IUserInformationRetrieveListener_OnUserInformationRetrieveSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUserInformationRetrieveListener_OnUserInformationRetrieveFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IUserInformationRetrieveListener();

		[PreserveSig]
		public static extern void delete_IUserInformationRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUserInformationRetrieveListener_director_connect(HandleRef jarg1, IUserInformationRetrieveListener.SwigDelegateIUserInformationRetrieveListener_0 delegate0, IUserInformationRetrieveListener.SwigDelegateIUserInformationRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void IFriendListListener_OnFriendListRetrieveSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendListListener_OnFriendListRetrieveFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_IFriendListListener();

		[PreserveSig]
		public static extern void delete_IFriendListListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendListListener_director_connect(HandleRef jarg1, IFriendListListener.SwigDelegateIFriendListListener_0 delegate0, IFriendListListener.SwigDelegateIFriendListListener_1 delegate1);

		[PreserveSig]
		public static extern void IFriendInvitationSendListener_OnFriendInvitationSendSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriendInvitationSendListener_OnFriendInvitationSendFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IFriendInvitationSendListener();

		[PreserveSig]
		public static extern void delete_IFriendInvitationSendListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendInvitationSendListener_director_connect(HandleRef jarg1, IFriendInvitationSendListener.SwigDelegateIFriendInvitationSendListener_0 delegate0, IFriendInvitationSendListener.SwigDelegateIFriendInvitationSendListener_1 delegate1);

		[PreserveSig]
		public static extern void IFriendInvitationListRetrieveListener_OnFriendInvitationListRetrieveSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendInvitationListRetrieveListener_OnFriendInvitationListRetrieveFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_IFriendInvitationListRetrieveListener();

		[PreserveSig]
		public static extern void delete_IFriendInvitationListRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendInvitationListRetrieveListener_director_connect(HandleRef jarg1, IFriendInvitationListRetrieveListener.SwigDelegateIFriendInvitationListRetrieveListener_0 delegate0, IFriendInvitationListRetrieveListener.SwigDelegateIFriendInvitationListRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void ISentFriendInvitationListRetrieveListener_OnSentFriendInvitationListRetrieveSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void ISentFriendInvitationListRetrieveListener_OnSentFriendInvitationListRetrieveFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_ISentFriendInvitationListRetrieveListener();

		[PreserveSig]
		public static extern void delete_ISentFriendInvitationListRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ISentFriendInvitationListRetrieveListener_director_connect(HandleRef jarg1, ISentFriendInvitationListRetrieveListener.SwigDelegateISentFriendInvitationListRetrieveListener_0 delegate0, ISentFriendInvitationListRetrieveListener.SwigDelegateISentFriendInvitationListRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void IFriendInvitationListener_OnFriendInvitationReceived(HandleRef jarg1, HandleRef jarg2, uint jarg3);

		[PreserveSig]
		public static extern IntPtr new_IFriendInvitationListener();

		[PreserveSig]
		public static extern void delete_IFriendInvitationListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendInvitationListener_director_connect(HandleRef jarg1, IFriendInvitationListener.SwigDelegateIFriendInvitationListener_0 delegate0);

		[PreserveSig]
		public static extern void IFriendInvitationRespondToListener_OnFriendInvitationRespondToSuccess(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[PreserveSig]
		public static extern void IFriendInvitationRespondToListener_OnFriendInvitationRespondToFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IFriendInvitationRespondToListener();

		[PreserveSig]
		public static extern void delete_IFriendInvitationRespondToListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendInvitationRespondToListener_director_connect(HandleRef jarg1, IFriendInvitationRespondToListener.SwigDelegateIFriendInvitationRespondToListener_0 delegate0, IFriendInvitationRespondToListener.SwigDelegateIFriendInvitationRespondToListener_1 delegate1);

		[PreserveSig]
		public static extern void IFriendAddListener_OnFriendAdded(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IFriendAddListener();

		[PreserveSig]
		public static extern void delete_IFriendAddListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendAddListener_director_connect(HandleRef jarg1, IFriendAddListener.SwigDelegateIFriendAddListener_0 delegate0);

		[PreserveSig]
		public static extern void IFriendDeleteListener_OnFriendDeleteSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriendDeleteListener_OnFriendDeleteFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IFriendDeleteListener();

		[PreserveSig]
		public static extern void delete_IFriendDeleteListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriendDeleteListener_director_connect(HandleRef jarg1, IFriendDeleteListener.SwigDelegateIFriendDeleteListener_0 delegate0, IFriendDeleteListener.SwigDelegateIFriendDeleteListener_1 delegate1);

		[PreserveSig]
		public static extern void IRichPresenceChangeListener_OnRichPresenceChangeSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void IRichPresenceChangeListener_OnRichPresenceChangeFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_IRichPresenceChangeListener();

		[PreserveSig]
		public static extern void delete_IRichPresenceChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IRichPresenceChangeListener_director_connect(HandleRef jarg1, IRichPresenceChangeListener.SwigDelegateIRichPresenceChangeListener_0 delegate0, IRichPresenceChangeListener.SwigDelegateIRichPresenceChangeListener_1 delegate1);

		[PreserveSig]
		public static extern void IRichPresenceListener_OnRichPresenceUpdated(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr new_IRichPresenceListener();

		[PreserveSig]
		public static extern void delete_IRichPresenceListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IRichPresenceListener_director_connect(HandleRef jarg1, IRichPresenceListener.SwigDelegateIRichPresenceListener_0 delegate0);

		[PreserveSig]
		public static extern void IRichPresenceRetrieveListener_OnRichPresenceRetrieveSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IRichPresenceRetrieveListener_OnRichPresenceRetrieveFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IRichPresenceRetrieveListener();

		[PreserveSig]
		public static extern void delete_IRichPresenceRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IRichPresenceRetrieveListener_director_connect(HandleRef jarg1, IRichPresenceRetrieveListener.SwigDelegateIRichPresenceRetrieveListener_0 delegate0, IRichPresenceRetrieveListener.SwigDelegateIRichPresenceRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void IGameJoinRequestedListener_OnGameJoinRequested(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[PreserveSig]
		public static extern IntPtr new_IGameJoinRequestedListener();

		[PreserveSig]
		public static extern void delete_IGameJoinRequestedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IGameJoinRequestedListener_director_connect(HandleRef jarg1, IGameJoinRequestedListener.SwigDelegateIGameJoinRequestedListener_0 delegate0);

		[PreserveSig]
		public static extern void IGameInvitationReceivedListener_OnGameInvitationReceived(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[PreserveSig]
		public static extern IntPtr new_IGameInvitationReceivedListener();

		[PreserveSig]
		public static extern void delete_IGameInvitationReceivedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IGameInvitationReceivedListener_director_connect(HandleRef jarg1, IGameInvitationReceivedListener.SwigDelegateIGameInvitationReceivedListener_0 delegate0);

		[PreserveSig]
		public static extern void ISendInvitationListener_OnInvitationSendSuccess(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[PreserveSig]
		public static extern void ISendInvitationListener_OnInvitationSendFailure(HandleRef jarg1, HandleRef jarg2, string jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ISendInvitationListener();

		[PreserveSig]
		public static extern void delete_ISendInvitationListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ISendInvitationListener_director_connect(HandleRef jarg1, ISendInvitationListener.SwigDelegateISendInvitationListener_0 delegate0, ISendInvitationListener.SwigDelegateISendInvitationListener_1 delegate1);

		[PreserveSig]
		public static extern void IUserFindListener_OnUserFindSuccess(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IUserFindListener_OnUserFindFailure(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IUserFindListener();

		[PreserveSig]
		public static extern void delete_IUserFindListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUserFindListener_director_connect(HandleRef jarg1, IUserFindListener.SwigDelegateIUserFindListener_0 delegate0, IUserFindListener.SwigDelegateIUserFindListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_IFriends(HandleRef jarg1);

		[PreserveSig]
		public static extern uint IFriends_GetDefaultAvatarCriteria(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriends_SetDefaultAvatarCriteria(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IFriends_RequestUserInformation__SWIG_0(HandleRef jarg1, HandleRef jarg2, uint jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IFriends_RequestUserInformation__SWIG_1(HandleRef jarg1, HandleRef jarg2, uint jarg3);

		[PreserveSig]
		public static extern void IFriends_RequestUserInformation__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool IFriends_IsUserInformationAvailable(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern string IFriends_GetPersonaName(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriends_GetPersonaNameCopy(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern int IFriends_GetPersonaState(HandleRef jarg1);

		[PreserveSig]
		public static extern string IFriends_GetFriendPersonaName(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_GetFriendPersonaNameCopy(HandleRef jarg1, HandleRef jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern int IFriends_GetFriendPersonaState(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern string IFriends_GetFriendAvatarUrl(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern void IFriends_GetFriendAvatarUrlCopy(HandleRef jarg1, HandleRef jarg2, int jarg3, byte[] jarg4, uint jarg5);

		[PreserveSig]
		public static extern uint IFriends_GetFriendAvatarImageID(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern void IFriends_GetFriendAvatarImageRGBA(HandleRef jarg1, HandleRef jarg2, int jarg3, byte[] jarg4, uint jarg5);

		[PreserveSig]
		public static extern bool IFriends_IsFriendAvatarImageRGBAAvailable(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern void IFriends_RequestFriendList__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_RequestFriendList__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern bool IFriends_IsFriend(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint IFriends_GetFriendCount(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr IFriends_GetFriendByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IFriends_SendFriendInvitation__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IFriends_SendFriendInvitation__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_RequestFriendInvitationList__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_RequestFriendInvitationList__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriends_RequestSentFriendInvitationList__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_RequestSentFriendInvitationList__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern uint IFriends_GetFriendInvitationCount(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriends_GetFriendInvitationByIndex(HandleRef jarg1, uint jarg2, HandleRef jarg3, ref uint jarg4);

		[PreserveSig]
		public static extern void IFriends_RespondToFriendInvitation__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IFriends_RespondToFriendInvitation__SWIG_1(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[PreserveSig]
		public static extern void IFriends_DeleteFriend__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IFriends_DeleteFriend__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_SetRichPresence__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IFriends_SetRichPresence__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void IFriends_DeleteRichPresence__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IFriends_DeleteRichPresence__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IFriends_ClearRichPresence__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_ClearRichPresence__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriends_RequestRichPresence__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IFriends_RequestRichPresence__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IFriends_RequestRichPresence__SWIG_2(HandleRef jarg1);

		[PreserveSig]
		public static extern string IFriends_GetRichPresence__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern string IFriends_GetRichPresence__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IFriends_GetRichPresenceCopy__SWIG_0(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IFriends_GetRichPresenceCopy__SWIG_1(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern uint IFriends_GetRichPresenceCount__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint IFriends_GetRichPresenceCount__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFriends_GetRichPresenceByIndex__SWIG_0(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4, byte[] jarg5, uint jarg6, HandleRef jarg7);

		[PreserveSig]
		public static extern void IFriends_GetRichPresenceByIndex__SWIG_1(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4, byte[] jarg5, uint jarg6);

		[PreserveSig]
		public static extern string IFriends_GetRichPresenceKeyByIndex__SWIG_0(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern string IFriends_GetRichPresenceKeyByIndex__SWIG_1(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IFriends_GetRichPresenceKeyByIndexCopy__SWIG_0(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IFriends_GetRichPresenceKeyByIndexCopy__SWIG_1(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IFriends_ShowOverlayInviteDialog(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IFriends_SendInvitation__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IFriends_SendInvitation__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[PreserveSig]
		public static extern void IFriends_FindUser__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IFriends_FindUser__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern bool IFriends_IsUserInTheSameGame(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUserStatsAndAchievementsRetrieveListener_OnUserStatsAndAchievementsRetrieveSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUserStatsAndAchievementsRetrieveListener_OnUserStatsAndAchievementsRetrieveFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IUserStatsAndAchievementsRetrieveListener();

		[PreserveSig]
		public static extern void delete_IUserStatsAndAchievementsRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUserStatsAndAchievementsRetrieveListener_director_connect(HandleRef jarg1, IUserStatsAndAchievementsRetrieveListener.SwigDelegateIUserStatsAndAchievementsRetrieveListener_0 delegate0, IUserStatsAndAchievementsRetrieveListener.SwigDelegateIUserStatsAndAchievementsRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void IStatsAndAchievementsStoreListener_OnUserStatsAndAchievementsStoreSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void IStatsAndAchievementsStoreListener_OnUserStatsAndAchievementsStoreFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_IStatsAndAchievementsStoreListener();

		[PreserveSig]
		public static extern void delete_IStatsAndAchievementsStoreListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IStatsAndAchievementsStoreListener_director_connect(HandleRef jarg1, IStatsAndAchievementsStoreListener.SwigDelegateIStatsAndAchievementsStoreListener_0 delegate0, IStatsAndAchievementsStoreListener.SwigDelegateIStatsAndAchievementsStoreListener_1 delegate1);

		[PreserveSig]
		public static extern void IAchievementChangeListener_OnAchievementUnlocked(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern IntPtr new_IAchievementChangeListener();

		[PreserveSig]
		public static extern void delete_IAchievementChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IAchievementChangeListener_director_connect(HandleRef jarg1, IAchievementChangeListener.SwigDelegateIAchievementChangeListener_0 delegate0);

		[PreserveSig]
		public static extern void ILeaderboardsRetrieveListener_OnLeaderboardsRetrieveSuccess(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILeaderboardsRetrieveListener_OnLeaderboardsRetrieveFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_ILeaderboardsRetrieveListener();

		[PreserveSig]
		public static extern void delete_ILeaderboardsRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILeaderboardsRetrieveListener_director_connect(HandleRef jarg1, ILeaderboardsRetrieveListener.SwigDelegateILeaderboardsRetrieveListener_0 delegate0, ILeaderboardsRetrieveListener.SwigDelegateILeaderboardsRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void ILeaderboardEntriesRetrieveListener_OnLeaderboardEntriesRetrieveSuccess(HandleRef jarg1, string jarg2, uint jarg3);

		[PreserveSig]
		public static extern void ILeaderboardEntriesRetrieveListener_OnLeaderboardEntriesRetrieveFailure(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILeaderboardEntriesRetrieveListener();

		[PreserveSig]
		public static extern void delete_ILeaderboardEntriesRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILeaderboardEntriesRetrieveListener_director_connect(HandleRef jarg1, ILeaderboardEntriesRetrieveListener.SwigDelegateILeaderboardEntriesRetrieveListener_0 delegate0, ILeaderboardEntriesRetrieveListener.SwigDelegateILeaderboardEntriesRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void ILeaderboardScoreUpdateListener_OnLeaderboardScoreUpdateSuccess(HandleRef jarg1, string jarg2, int jarg3, uint jarg4, uint jarg5);

		[PreserveSig]
		public static extern void ILeaderboardScoreUpdateListener_OnLeaderboardScoreUpdateFailure(HandleRef jarg1, string jarg2, int jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ILeaderboardScoreUpdateListener();

		[PreserveSig]
		public static extern void delete_ILeaderboardScoreUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILeaderboardScoreUpdateListener_director_connect(HandleRef jarg1, ILeaderboardScoreUpdateListener.SwigDelegateILeaderboardScoreUpdateListener_0 delegate0, ILeaderboardScoreUpdateListener.SwigDelegateILeaderboardScoreUpdateListener_1 delegate1);

		[PreserveSig]
		public static extern void ILeaderboardRetrieveListener_OnLeaderboardRetrieveSuccess(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ILeaderboardRetrieveListener_OnLeaderboardRetrieveFailure(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILeaderboardRetrieveListener();

		[PreserveSig]
		public static extern void delete_ILeaderboardRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILeaderboardRetrieveListener_director_connect(HandleRef jarg1, ILeaderboardRetrieveListener.SwigDelegateILeaderboardRetrieveListener_0 delegate0, ILeaderboardRetrieveListener.SwigDelegateILeaderboardRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void IUserTimePlayedRetrieveListener_OnUserTimePlayedRetrieveSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IUserTimePlayedRetrieveListener_OnUserTimePlayedRetrieveFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IUserTimePlayedRetrieveListener();

		[PreserveSig]
		public static extern void delete_IUserTimePlayedRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IUserTimePlayedRetrieveListener_director_connect(HandleRef jarg1, IUserTimePlayedRetrieveListener.SwigDelegateIUserTimePlayedRetrieveListener_0 delegate0, IUserTimePlayedRetrieveListener.SwigDelegateIUserTimePlayedRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_IStats(HandleRef jarg1);

		[PreserveSig]
		public static extern void IStats_RequestUserStatsAndAchievements__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IStats_RequestUserStatsAndAchievements__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IStats_RequestUserStatsAndAchievements__SWIG_2(HandleRef jarg1);

		[PreserveSig]
		public static extern int IStats_GetStatInt__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern int IStats_GetStatInt__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern float IStats_GetStatFloat__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern float IStats_GetStatFloat__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_SetStatInt(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern void IStats_SetStatFloat(HandleRef jarg1, string jarg2, float jarg3);

		[PreserveSig]
		public static extern void IStats_UpdateAvgRateStat(HandleRef jarg1, string jarg2, float jarg3, double jarg4);

		[PreserveSig]
		public static extern uint IStats_GetAchievementsNumber(HandleRef jarg1);

		[PreserveSig]
		public static extern string IStats_GetAchievementName(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IStats_GetAchievementNameCopy(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IStats_GetAchievement__SWIG_0(HandleRef jarg1, string jarg2, ref bool jarg3, ref uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IStats_GetAchievement__SWIG_1(HandleRef jarg1, string jarg2, ref bool jarg3, ref uint jarg4);

		[PreserveSig]
		public static extern void IStats_SetAchievement(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_ClearAchievement(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_StoreStatsAndAchievements__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IStats_StoreStatsAndAchievements__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IStats_ResetStatsAndAchievements__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IStats_ResetStatsAndAchievements__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern string IStats_GetAchievementDisplayName(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_GetAchievementDisplayNameCopy(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern string IStats_GetAchievementDescription(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_GetAchievementDescriptionCopy(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern bool IStats_IsAchievementVisible(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern bool IStats_IsAchievementVisibleWhileLocked(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboards__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboards__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern string IStats_GetLeaderboardDisplayName(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_GetLeaderboardDisplayNameCopy(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern int IStats_GetLeaderboardSortMethod(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern int IStats_GetLeaderboardDisplayType(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboardEntriesGlobal__SWIG_0(HandleRef jarg1, string jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboardEntriesGlobal__SWIG_1(HandleRef jarg1, string jarg2, uint jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboardEntriesAroundUser__SWIG_0(HandleRef jarg1, string jarg2, uint jarg3, uint jarg4, HandleRef jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboardEntriesAroundUser__SWIG_1(HandleRef jarg1, string jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboardEntriesAroundUser__SWIG_2(HandleRef jarg1, string jarg2, uint jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboardEntriesForUsers__SWIG_0(HandleRef jarg1, string jarg2, ulong[] array, uint jarg3, HandleRef jarg5);

		[PreserveSig]
		public static extern void IStats_RequestLeaderboardEntriesForUsers__SWIG_1(HandleRef jarg1, string jarg2, ulong[] array, uint jarg3);

		[PreserveSig]
		public static extern void IStats_GetRequestedLeaderboardEntry(HandleRef jarg1, uint jarg2, ref uint jarg3, ref int jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IStats_GetRequestedLeaderboardEntryWithDetails(HandleRef jarg1, uint jarg2, ref uint jarg3, ref int jarg4, byte[] jarg5, uint jarg6, ref uint jarg7, HandleRef jarg8);

		[PreserveSig]
		public static extern void IStats_SetLeaderboardScore__SWIG_0(HandleRef jarg1, string jarg2, int jarg3, bool jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IStats_SetLeaderboardScore__SWIG_1(HandleRef jarg1, string jarg2, int jarg3, bool jarg4);

		[PreserveSig]
		public static extern void IStats_SetLeaderboardScore__SWIG_2(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern void IStats_SetLeaderboardScoreWithDetails__SWIG_0(HandleRef jarg1, string jarg2, int jarg3, byte[] jarg4, uint jarg5, bool jarg6, HandleRef jarg7);

		[PreserveSig]
		public static extern void IStats_SetLeaderboardScoreWithDetails__SWIG_1(HandleRef jarg1, string jarg2, int jarg3, byte[] jarg4, uint jarg5, bool jarg6);

		[PreserveSig]
		public static extern void IStats_SetLeaderboardScoreWithDetails__SWIG_2(HandleRef jarg1, string jarg2, int jarg3, byte[] jarg4, uint jarg5);

		[PreserveSig]
		public static extern uint IStats_GetLeaderboardEntryCount(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_FindLeaderboard__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IStats_FindLeaderboard__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStats_FindOrCreateLeaderboard__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, int jarg4, int jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern void IStats_FindOrCreateLeaderboard__SWIG_1(HandleRef jarg1, string jarg2, string jarg3, int jarg4, int jarg5);

		[PreserveSig]
		public static extern void IStats_RequestUserTimePlayed__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IStats_RequestUserTimePlayed__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IStats_RequestUserTimePlayed__SWIG_2(HandleRef jarg1);

		[PreserveSig]
		public static extern uint IStats_GetUserTimePlayed__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint IStats_GetUserTimePlayed__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFileShareListener_OnFileShareSuccess(HandleRef jarg1, string jarg2, ulong jarg3);

		[PreserveSig]
		public static extern void IFileShareListener_OnFileShareFailure(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IFileShareListener();

		[PreserveSig]
		public static extern void delete_IFileShareListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IFileShareListener_director_connect(HandleRef jarg1, IFileShareListener.SwigDelegateIFileShareListener_0 delegate0, IFileShareListener.SwigDelegateIFileShareListener_1 delegate1);

		[PreserveSig]
		public static extern void ISharedFileDownloadListener_OnSharedFileDownloadSuccess(HandleRef jarg1, ulong jarg2, string jarg3);

		[PreserveSig]
		public static extern void ISharedFileDownloadListener_OnSharedFileDownloadFailure(HandleRef jarg1, ulong jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ISharedFileDownloadListener();

		[PreserveSig]
		public static extern void delete_ISharedFileDownloadListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ISharedFileDownloadListener_director_connect(HandleRef jarg1, ISharedFileDownloadListener.SwigDelegateISharedFileDownloadListener_0 delegate0, ISharedFileDownloadListener.SwigDelegateISharedFileDownloadListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_IStorage(HandleRef jarg1);

		[PreserveSig]
		public static extern void IStorage_FileWrite(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern uint IStorage_FileRead(HandleRef jarg1, string jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IStorage_FileDelete(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern bool IStorage_FileExists(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern uint IStorage_GetFileSize(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern uint IStorage_GetFileTimestamp(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern uint IStorage_GetFileCount(HandleRef jarg1);

		[PreserveSig]
		public static extern string IStorage_GetFileNameByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IStorage_GetFileNameCopyByIndex(HandleRef jarg1, uint jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IStorage_FileShare__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IStorage_FileShare__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void IStorage_DownloadSharedFile__SWIG_0(HandleRef jarg1, ulong jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IStorage_DownloadSharedFile__SWIG_1(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern string IStorage_GetSharedFileName(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern void IStorage_GetSharedFileNameCopy(HandleRef jarg1, ulong jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern uint IStorage_GetSharedFileSize(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern IntPtr IStorage_GetSharedFileOwner(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern uint IStorage_SharedFileRead__SWIG_0(HandleRef jarg1, ulong jarg2, byte[] jarg3, uint jarg4, uint jarg5);

		[PreserveSig]
		public static extern uint IStorage_SharedFileRead__SWIG_1(HandleRef jarg1, ulong jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IStorage_SharedFileClose(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern uint IStorage_GetDownloadedSharedFileCount(HandleRef jarg1);

		[PreserveSig]
		public static extern ulong IStorage_GetDownloadedSharedFileByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IConnectionOpenListener_OnConnectionOpenSuccess(HandleRef jarg1, string jarg2, ulong jarg3);

		[PreserveSig]
		public static extern void IConnectionOpenListener_OnConnectionOpenFailure(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IConnectionOpenListener();

		[PreserveSig]
		public static extern void delete_IConnectionOpenListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IConnectionOpenListener_director_connect(HandleRef jarg1, IConnectionOpenListener.SwigDelegateIConnectionOpenListener_0 delegate0, IConnectionOpenListener.SwigDelegateIConnectionOpenListener_1 delegate1);

		[PreserveSig]
		public static extern void IConnectionCloseListener_OnConnectionClosed(HandleRef jarg1, ulong jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IConnectionCloseListener();

		[PreserveSig]
		public static extern void delete_IConnectionCloseListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IConnectionCloseListener_director_connect(HandleRef jarg1, IConnectionCloseListener.SwigDelegateIConnectionCloseListener_0 delegate0);

		[PreserveSig]
		public static extern void IConnectionDataListener_OnConnectionDataReceived(HandleRef jarg1, ulong jarg2, uint jarg3);

		[PreserveSig]
		public static extern IntPtr new_IConnectionDataListener();

		[PreserveSig]
		public static extern void delete_IConnectionDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IConnectionDataListener_director_connect(HandleRef jarg1, IConnectionDataListener.SwigDelegateIConnectionDataListener_0 delegate0);

		[PreserveSig]
		public static extern void delete_ICustomNetworking(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICustomNetworking_OpenConnection__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void ICustomNetworking_OpenConnection__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ICustomNetworking_CloseConnection__SWIG_0(HandleRef jarg1, ulong jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void ICustomNetworking_CloseConnection__SWIG_1(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern void ICustomNetworking_SendData(HandleRef jarg1, ulong jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern uint ICustomNetworking_GetAvailableDataSize(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern void ICustomNetworking_PeekData(HandleRef jarg1, ulong jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void ICustomNetworking_ReadData(HandleRef jarg1, ulong jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern void ICustomNetworking_PopData(HandleRef jarg1, ulong jarg2, uint jarg3);

		[PreserveSig]
		public static extern void INetworkingListener_OnP2PPacketAvailable(HandleRef jarg1, uint jarg2, byte jarg3);

		[PreserveSig]
		public static extern IntPtr new_INetworkingListener();

		[PreserveSig]
		public static extern void delete_INetworkingListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void INetworkingListener_director_connect(HandleRef jarg1, INetworkingListener.SwigDelegateINetworkingListener_0 delegate0);

		[PreserveSig]
		public static extern void INatTypeDetectionListener_OnNatTypeDetectionSuccess(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void INatTypeDetectionListener_OnNatTypeDetectionFailure(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_INatTypeDetectionListener();

		[PreserveSig]
		public static extern void delete_INatTypeDetectionListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void INatTypeDetectionListener_director_connect(HandleRef jarg1, INatTypeDetectionListener.SwigDelegateINatTypeDetectionListener_0 delegate0, INatTypeDetectionListener.SwigDelegateINatTypeDetectionListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_INetworking(HandleRef jarg1);

		[PreserveSig]
		public static extern bool INetworking_SendP2PPacket__SWIG_0(HandleRef jarg1, HandleRef jarg2, byte[] jarg3, uint jarg4, int jarg5, byte jarg6);

		[PreserveSig]
		public static extern bool INetworking_SendP2PPacket__SWIG_1(HandleRef jarg1, HandleRef jarg2, byte[] jarg3, uint jarg4, int jarg5);

		[PreserveSig]
		public static extern bool INetworking_PeekP2PPacket__SWIG_0(HandleRef jarg1, byte[] jarg2, uint jarg3, ref uint jarg4, HandleRef jarg5, byte jarg6);

		[PreserveSig]
		public static extern bool INetworking_PeekP2PPacket__SWIG_1(HandleRef jarg1, byte[] jarg2, uint jarg3, ref uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern bool INetworking_IsP2PPacketAvailable__SWIG_0(HandleRef jarg1, ref uint jarg2, byte jarg3);

		[PreserveSig]
		public static extern bool INetworking_IsP2PPacketAvailable__SWIG_1(HandleRef jarg1, ref uint jarg2);

		[PreserveSig]
		public static extern bool INetworking_ReadP2PPacket__SWIG_0(HandleRef jarg1, byte[] jarg2, uint jarg3, ref uint jarg4, HandleRef jarg5, byte jarg6);

		[PreserveSig]
		public static extern bool INetworking_ReadP2PPacket__SWIG_1(HandleRef jarg1, byte[] jarg2, uint jarg3, ref uint jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void INetworking_PopP2PPacket__SWIG_0(HandleRef jarg1, byte jarg2);

		[PreserveSig]
		public static extern void INetworking_PopP2PPacket__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern int INetworking_GetPingWith(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void INetworking_RequestNatTypeDetection(HandleRef jarg1);

		[PreserveSig]
		public static extern int INetworking_GetNatType(HandleRef jarg1);

		[PreserveSig]
		public static extern int INetworking_GetConnectionType(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void ILobbyListListener_OnLobbyList(HandleRef jarg1, uint jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyListListener();

		[PreserveSig]
		public static extern void delete_ILobbyListListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyListListener_director_connect(HandleRef jarg1, ILobbyListListener.SwigDelegateILobbyListListener_0 delegate0);

		[PreserveSig]
		public static extern void ILobbyCreatedListener_OnLobbyCreated(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyCreatedListener();

		[PreserveSig]
		public static extern void delete_ILobbyCreatedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyCreatedListener_director_connect(HandleRef jarg1, ILobbyCreatedListener.SwigDelegateILobbyCreatedListener_0 delegate0);

		[PreserveSig]
		public static extern void ILobbyEnteredListener_OnLobbyEntered(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyEnteredListener();

		[PreserveSig]
		public static extern void delete_ILobbyEnteredListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyEnteredListener_director_connect(HandleRef jarg1, ILobbyEnteredListener.SwigDelegateILobbyEnteredListener_0 delegate0);

		[PreserveSig]
		public static extern void ILobbyLeftListener_OnLobbyLeft(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyLeftListener();

		[PreserveSig]
		public static extern void delete_ILobbyLeftListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyLeftListener_director_connect(HandleRef jarg1, ILobbyLeftListener.SwigDelegateILobbyLeftListener_0 delegate0);

		[PreserveSig]
		public static extern void ILobbyDataListener_OnLobbyDataUpdated(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyDataListener();

		[PreserveSig]
		public static extern void delete_ILobbyDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyDataListener_director_connect(HandleRef jarg1, ILobbyDataListener.SwigDelegateILobbyDataListener_0 delegate0);

		[PreserveSig]
		public static extern void ILobbyDataUpdateListener_OnLobbyDataUpdateSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void ILobbyDataUpdateListener_OnLobbyDataUpdateFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyDataUpdateListener();

		[PreserveSig]
		public static extern void delete_ILobbyDataUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyDataUpdateListener_director_connect(HandleRef jarg1, ILobbyDataUpdateListener.SwigDelegateILobbyDataUpdateListener_0 delegate0, ILobbyDataUpdateListener.SwigDelegateILobbyDataUpdateListener_1 delegate1);

		[PreserveSig]
		public static extern void ILobbyMemberDataUpdateListener_OnLobbyMemberDataUpdateSuccess(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void ILobbyMemberDataUpdateListener_OnLobbyMemberDataUpdateFailure(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ILobbyMemberDataUpdateListener();

		[PreserveSig]
		public static extern void delete_ILobbyMemberDataUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyMemberDataUpdateListener_director_connect(HandleRef jarg1, ILobbyMemberDataUpdateListener.SwigDelegateILobbyMemberDataUpdateListener_0 delegate0, ILobbyMemberDataUpdateListener.SwigDelegateILobbyMemberDataUpdateListener_1 delegate1);

		[PreserveSig]
		public static extern void ILobbyDataRetrieveListener_OnLobbyDataRetrieveSuccess(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void ILobbyDataRetrieveListener_OnLobbyDataRetrieveFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyDataRetrieveListener();

		[PreserveSig]
		public static extern void delete_ILobbyDataRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyDataRetrieveListener_director_connect(HandleRef jarg1, ILobbyDataRetrieveListener.SwigDelegateILobbyDataRetrieveListener_0 delegate0, ILobbyDataRetrieveListener.SwigDelegateILobbyDataRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void ILobbyMemberStateListener_OnLobbyMemberStateChanged(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ILobbyMemberStateListener();

		[PreserveSig]
		public static extern void delete_ILobbyMemberStateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyMemberStateListener_director_connect(HandleRef jarg1, ILobbyMemberStateListener.SwigDelegateILobbyMemberStateListener_0 delegate0);

		[PreserveSig]
		public static extern void ILobbyOwnerChangeListener_OnLobbyOwnerChanged(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern IntPtr new_ILobbyOwnerChangeListener();

		[PreserveSig]
		public static extern void delete_ILobbyOwnerChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyOwnerChangeListener_director_connect(HandleRef jarg1, ILobbyOwnerChangeListener.SwigDelegateILobbyOwnerChangeListener_0 delegate0);

		[PreserveSig]
		public static extern void ILobbyMessageListener_OnLobbyMessageReceived(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, uint jarg4, uint jarg5);

		[PreserveSig]
		public static extern IntPtr new_ILobbyMessageListener();

		[PreserveSig]
		public static extern void delete_ILobbyMessageListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ILobbyMessageListener_director_connect(HandleRef jarg1, ILobbyMessageListener.SwigDelegateILobbyMessageListener_0 delegate0);

		[PreserveSig]
		public static extern void delete_IMatchmaking(HandleRef jarg1);

		[PreserveSig]
		public static extern void IMatchmaking_CreateLobby__SWIG_0(HandleRef jarg1, int jarg2, uint jarg3, bool jarg4, int jarg5, HandleRef jarg6, HandleRef jarg7);

		[PreserveSig]
		public static extern void IMatchmaking_CreateLobby__SWIG_1(HandleRef jarg1, int jarg2, uint jarg3, bool jarg4, int jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern void IMatchmaking_CreateLobby__SWIG_2(HandleRef jarg1, int jarg2, uint jarg3, bool jarg4, int jarg5);

		[PreserveSig]
		public static extern void IMatchmaking_RequestLobbyList__SWIG_0(HandleRef jarg1, bool jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IMatchmaking_RequestLobbyList__SWIG_1(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		public static extern void IMatchmaking_RequestLobbyList__SWIG_2(HandleRef jarg1);

		[PreserveSig]
		public static extern void IMatchmaking_AddRequestLobbyListResultCountFilter(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IMatchmaking_AddRequestLobbyListStringFilter(HandleRef jarg1, string jarg2, string jarg3, int jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_AddRequestLobbyListNumericalFilter(HandleRef jarg1, string jarg2, int jarg3, int jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_AddRequestLobbyListNearValueFilter(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr IMatchmaking_GetLobbyByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void IMatchmaking_JoinLobby__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IMatchmaking_JoinLobby__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IMatchmaking_LeaveLobby__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IMatchmaking_LeaveLobby__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IMatchmaking_SetMaxNumLobbyMembers__SWIG_0(HandleRef jarg1, HandleRef jarg2, uint jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_SetMaxNumLobbyMembers__SWIG_1(HandleRef jarg1, HandleRef jarg2, uint jarg3);

		[PreserveSig]
		public static extern uint IMatchmaking_GetMaxNumLobbyMembers(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint IMatchmaking_GetNumLobbyMembers(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr IMatchmaking_GetLobbyMemberByIndex(HandleRef jarg1, HandleRef jarg2, uint jarg3);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyType__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyType__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern int IMatchmaking_GetLobbyType(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyJoinable__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyJoinable__SWIG_1(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[PreserveSig]
		public static extern bool IMatchmaking_IsLobbyJoinable(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IMatchmaking_RequestLobbyData__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IMatchmaking_RequestLobbyData__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern string IMatchmaking_GetLobbyData(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[PreserveSig]
		public static extern void IMatchmaking_GetLobbyDataCopy(HandleRef jarg1, HandleRef jarg2, string jarg3, byte[] jarg4, uint jarg5);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyData__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyData__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4);

		[PreserveSig]
		public static extern uint IMatchmaking_GetLobbyDataCount(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool IMatchmaking_GetLobbyDataByIndex(HandleRef jarg1, HandleRef jarg2, uint jarg3, byte[] jarg4, uint jarg5, byte[] jarg6, uint jarg7);

		[PreserveSig]
		public static extern void IMatchmaking_DeleteLobbyData__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_DeleteLobbyData__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[PreserveSig]
		public static extern string IMatchmaking_GetLobbyMemberData(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, string jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_GetLobbyMemberDataCopy(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, string jarg4, byte[] jarg5, uint jarg6);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyMemberData__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IMatchmaking_SetLobbyMemberData__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4);

		[PreserveSig]
		public static extern uint IMatchmaking_GetLobbyMemberDataCount(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern bool IMatchmaking_GetLobbyMemberDataByIndex(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, uint jarg4, byte[] jarg5, uint jarg6, byte[] jarg7, uint jarg8);

		[PreserveSig]
		public static extern void IMatchmaking_DeleteLobbyMemberData__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void IMatchmaking_DeleteLobbyMemberData__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[PreserveSig]
		public static extern IntPtr IMatchmaking_GetLobbyOwner(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool IMatchmaking_SendLobbyMessage(HandleRef jarg1, HandleRef jarg2, byte[] jarg3, uint jarg4);

		[PreserveSig]
		public static extern uint IMatchmaking_GetLobbyMessage(HandleRef jarg1, HandleRef jarg2, uint jarg3, HandleRef jarg4, byte[] jarg5, uint jarg6);

		[PreserveSig]
		public static extern void IChatRoomWithUserRetrieveListener_OnChatRoomWithUserRetrieveSuccess(HandleRef jarg1, HandleRef jarg2, ulong jarg3);

		[PreserveSig]
		public static extern void IChatRoomWithUserRetrieveListener_OnChatRoomWithUserRetrieveFailure(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IChatRoomWithUserRetrieveListener();

		[PreserveSig]
		public static extern void delete_IChatRoomWithUserRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IChatRoomWithUserRetrieveListener_director_connect(HandleRef jarg1, IChatRoomWithUserRetrieveListener.SwigDelegateIChatRoomWithUserRetrieveListener_0 delegate0, IChatRoomWithUserRetrieveListener.SwigDelegateIChatRoomWithUserRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void IChatRoomMessageSendListener_OnChatRoomMessageSendSuccess(HandleRef jarg1, ulong jarg2, uint jarg3, ulong jarg4, uint jarg5);

		[PreserveSig]
		public static extern void IChatRoomMessageSendListener_OnChatRoomMessageSendFailure(HandleRef jarg1, ulong jarg2, uint jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_IChatRoomMessageSendListener();

		[PreserveSig]
		public static extern void delete_IChatRoomMessageSendListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IChatRoomMessageSendListener_director_connect(HandleRef jarg1, IChatRoomMessageSendListener.SwigDelegateIChatRoomMessageSendListener_0 delegate0, IChatRoomMessageSendListener.SwigDelegateIChatRoomMessageSendListener_1 delegate1);

		[PreserveSig]
		public static extern void IChatRoomMessagesListener_OnChatRoomMessagesReceived(HandleRef jarg1, ulong jarg2, uint jarg3, uint jarg4);

		[PreserveSig]
		public static extern IntPtr new_IChatRoomMessagesListener();

		[PreserveSig]
		public static extern void delete_IChatRoomMessagesListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IChatRoomMessagesListener_director_connect(HandleRef jarg1, IChatRoomMessagesListener.SwigDelegateIChatRoomMessagesListener_0 delegate0);

		[PreserveSig]
		public static extern void IChatRoomMessagesRetrieveListener_OnChatRoomMessagesRetrieveSuccess(HandleRef jarg1, ulong jarg2, uint jarg3, uint jarg4);

		[PreserveSig]
		public static extern void IChatRoomMessagesRetrieveListener_OnChatRoomMessagesRetrieveFailure(HandleRef jarg1, ulong jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr new_IChatRoomMessagesRetrieveListener();

		[PreserveSig]
		public static extern void delete_IChatRoomMessagesRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void IChatRoomMessagesRetrieveListener_director_connect(HandleRef jarg1, IChatRoomMessagesRetrieveListener.SwigDelegateIChatRoomMessagesRetrieveListener_0 delegate0, IChatRoomMessagesRetrieveListener.SwigDelegateIChatRoomMessagesRetrieveListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_IChat(HandleRef jarg1);

		[PreserveSig]
		public static extern void IChat_RequestChatRoomWithUser__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void IChat_RequestChatRoomWithUser__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void IChat_RequestChatRoomMessages__SWIG_0(HandleRef jarg1, ulong jarg2, uint jarg3, ulong jarg4, HandleRef jarg5);

		[PreserveSig]
		public static extern void IChat_RequestChatRoomMessages__SWIG_1(HandleRef jarg1, ulong jarg2, uint jarg3, ulong jarg4);

		[PreserveSig]
		public static extern void IChat_RequestChatRoomMessages__SWIG_2(HandleRef jarg1, ulong jarg2, uint jarg3);

		[PreserveSig]
		public static extern uint IChat_SendChatRoomMessage__SWIG_0(HandleRef jarg1, ulong jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern uint IChat_SendChatRoomMessage__SWIG_1(HandleRef jarg1, ulong jarg2, string jarg3);

		[PreserveSig]
		public static extern uint IChat_GetChatRoomMessageByIndex(HandleRef jarg1, uint jarg2, ref ulong jarg3, ref int jarg4, HandleRef jarg5, ref uint jarg6, byte[] jarg7, uint jarg8);

		[PreserveSig]
		public static extern uint IChat_GetChatRoomMemberCount(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern IntPtr IChat_GetChatRoomMemberUserIDByIndex(HandleRef jarg1, ulong jarg2, uint jarg3);

		[PreserveSig]
		public static extern uint IChat_GetChatRoomUnreadMessageCount(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern void IChat_MarkChatRoomAsRead(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		public static extern void ITelemetryEventSendListener_OnTelemetryEventSendSuccess(HandleRef jarg1, string jarg2, uint jarg3);

		[PreserveSig]
		public static extern void ITelemetryEventSendListener_OnTelemetryEventSendFailure(HandleRef jarg1, string jarg2, uint jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ITelemetryEventSendListener();

		[PreserveSig]
		public static extern void delete_ITelemetryEventSendListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ITelemetryEventSendListener_director_connect(HandleRef jarg1, ITelemetryEventSendListener.SwigDelegateITelemetryEventSendListener_0 delegate0, ITelemetryEventSendListener.SwigDelegateITelemetryEventSendListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_ITelemetry(HandleRef jarg1);

		[PreserveSig]
		public static extern void ITelemetry_AddStringParam(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void ITelemetry_AddIntParam(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern void ITelemetry_AddFloatParam(HandleRef jarg1, string jarg2, double jarg3);

		[PreserveSig]
		public static extern void ITelemetry_AddBoolParam(HandleRef jarg1, string jarg2, bool jarg3);

		[PreserveSig]
		public static extern void ITelemetry_AddObjectParam(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ITelemetry_AddArrayParam(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void ITelemetry_CloseParam(HandleRef jarg1);

		[PreserveSig]
		public static extern void ITelemetry_ClearParams(HandleRef jarg1);

		[PreserveSig]
		public static extern void ITelemetry_SetSamplingClass(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern uint ITelemetry_SendTelemetryEvent__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern uint ITelemetry_SendTelemetryEvent__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern uint ITelemetry_SendAnonymousTelemetryEvent__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern uint ITelemetry_SendAnonymousTelemetryEvent__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string ITelemetry_GetVisitID(HandleRef jarg1);

		[PreserveSig]
		public static extern void ITelemetry_GetVisitIDCopy(HandleRef jarg1, byte[] jarg2, uint jarg3);

		[PreserveSig]
		public static extern void ITelemetry_ResetVisitID(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICloudStorageGetFileListListener_OnGetFileListSuccess(HandleRef jarg1, uint jarg2, uint jarg3, uint jarg4);

		[PreserveSig]
		public static extern void ICloudStorageGetFileListListener_OnGetFileListFailure(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr new_ICloudStorageGetFileListListener();

		[PreserveSig]
		public static extern void delete_ICloudStorageGetFileListListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICloudStorageGetFileListListener_director_connect(HandleRef jarg1, ICloudStorageGetFileListListener.SwigDelegateICloudStorageGetFileListListener_0 delegate0, ICloudStorageGetFileListListener.SwigDelegateICloudStorageGetFileListListener_1 delegate1);

		[PreserveSig]
		public static extern void ICloudStorageGetFileListener_OnGetFileSuccess(HandleRef jarg1, string jarg2, string jarg3, uint jarg4, int jarg5, string jarg6);

		[PreserveSig]
		public static extern void ICloudStorageGetFileListener_OnGetFileFailure(HandleRef jarg1, string jarg2, string jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ICloudStorageGetFileListener();

		[PreserveSig]
		public static extern void delete_ICloudStorageGetFileListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICloudStorageGetFileListener_director_connect(HandleRef jarg1, ICloudStorageGetFileListener.SwigDelegateICloudStorageGetFileListener_0 delegate0, ICloudStorageGetFileListener.SwigDelegateICloudStorageGetFileListener_1 delegate1);

		[PreserveSig]
		public static extern void ICloudStoragePutFileListener_OnPutFileSuccess(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void ICloudStoragePutFileListener_OnPutFileFailure(HandleRef jarg1, string jarg2, string jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ICloudStoragePutFileListener();

		[PreserveSig]
		public static extern void delete_ICloudStoragePutFileListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICloudStoragePutFileListener_director_connect(HandleRef jarg1, ICloudStoragePutFileListener.SwigDelegateICloudStoragePutFileListener_0 delegate0, ICloudStoragePutFileListener.SwigDelegateICloudStoragePutFileListener_1 delegate1);

		[PreserveSig]
		public static extern void ICloudStorageDeleteFileListener_OnDeleteFileSuccess(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void ICloudStorageDeleteFileListener_OnDeleteFileFailure(HandleRef jarg1, string jarg2, string jarg3, int jarg4);

		[PreserveSig]
		public static extern IntPtr new_ICloudStorageDeleteFileListener();

		[PreserveSig]
		public static extern void delete_ICloudStorageDeleteFileListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICloudStorageDeleteFileListener_director_connect(HandleRef jarg1, ICloudStorageDeleteFileListener.SwigDelegateICloudStorageDeleteFileListener_0 delegate0, ICloudStorageDeleteFileListener.SwigDelegateICloudStorageDeleteFileListener_1 delegate1);

		[PreserveSig]
		public static extern void delete_ICloudStorage(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICloudStorage_GetFileList(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern string ICloudStorage_GetFileNameByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern uint ICloudStorage_GetFileSizeByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern uint ICloudStorage_GetFileTimestampByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern string ICloudStorage_GetFileHashByIndex(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern void ICloudStorage_GetFile__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, IntPtr jarg4, HandleRef jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern void ICloudStorage_GetFile__SWIG_1(HandleRef jarg1, string jarg2, string jarg3, byte[] jarg4, uint jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern void ICloudStorage_GetFileMetadata(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, IntPtr jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7, int jarg8, uint jarg9, string jarg10);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_1(HandleRef jarg1, string jarg2, string jarg3, IntPtr jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7, int jarg8, uint jarg9);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_2(HandleRef jarg1, string jarg2, string jarg3, IntPtr jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7, int jarg8);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_3(HandleRef jarg1, string jarg2, string jarg3, IntPtr jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_4(HandleRef jarg1, string jarg2, string jarg3, byte[] jarg4, uint jarg5, HandleRef jarg6, int jarg7, uint jarg8, string jarg9);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_5(HandleRef jarg1, string jarg2, string jarg3, byte[] jarg4, uint jarg5, HandleRef jarg6, int jarg7, uint jarg8);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_6(HandleRef jarg1, string jarg2, string jarg3, byte[] jarg4, uint jarg5, HandleRef jarg6, int jarg7);

		[PreserveSig]
		public static extern void ICloudStorage_PutFile__SWIG_7(HandleRef jarg1, string jarg2, string jarg3, byte[] jarg4, uint jarg5, HandleRef jarg6);

		[PreserveSig]
		public static extern uint ICloudStorage_MIN_HASH_BUFFER_SIZE_get();

		[PreserveSig]
		public static extern void ICloudStorage_CalculateHash__SWIG_0(HandleRef jarg1, IntPtr jarg2, HandleRef jarg3, HandleRef jarg4, byte[] jarg5, uint jarg6);

		[PreserveSig]
		public static extern void ICloudStorage_CalculateHash__SWIG_1(HandleRef jarg1, byte[] jarg2, uint jarg3, byte[] jarg4, uint jarg5);

		[PreserveSig]
		public static extern void ICloudStorage_DeleteFile__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4, string jarg5);

		[PreserveSig]
		public static extern void ICloudStorage_DeleteFile__SWIG_1(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[PreserveSig]
		public static extern void ICloudStorage_OpenSavegame(HandleRef jarg1);

		[PreserveSig]
		public static extern void ICloudStorage_CloseSavegame(HandleRef jarg1);

		[PreserveSig]
		public static extern ulong GalaxyID_UNASSIGNED_VALUE_get();

		[PreserveSig]
		public static extern IntPtr GalaxyID_FromRealID(int jarg1, ulong jarg2);

		[PreserveSig]
		public static extern IntPtr new_GalaxyID__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_GalaxyID__SWIG_1(ulong jarg1);

		[PreserveSig]
		public static extern IntPtr new_GalaxyID__SWIG_2(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyID_operator_assign(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool GalaxyID_operator_less(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool GalaxyID_operator_equals(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool GalaxyID_operator_not_equals(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern bool GalaxyID_IsValid(HandleRef jarg1);

		[PreserveSig]
		public static extern ulong GalaxyID_ToUint64(HandleRef jarg1);

		[PreserveSig]
		public static extern ulong GalaxyID_GetRealID(HandleRef jarg1);

		[PreserveSig]
		public static extern int GalaxyID_GetIDType(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GalaxyID(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalOverlayVisibilityChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalOverlayInitializationStateChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalGogServicesConnectionStateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalGogServicesConnectionStateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalAuthListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalAuthListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalOtherSessionStartListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalOperationalStateChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalOperationalStateChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalUserDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalSpecificUserDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalSpecificUserDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalEncryptedAppTicketListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalEncryptedAppTicketListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalAccessTokenListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalAccessTokenListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyListListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyCreatedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyCreatedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyEnteredListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyEnteredListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyLeftListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyLeftListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyDataUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyDataUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyMemberDataUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyMemberDataUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyDataRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyDataRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyMemberStateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyMemberStateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyOwnerChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLobbyMessageListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalLobbyMessageListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalUserStatsAndAchievementsRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalStatsAndAchievementsStoreListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalAchievementChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLeaderboardsRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLeaderboardEntriesRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLeaderboardScoreUpdateListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalLeaderboardRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalUserTimePlayedRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFileShareListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalSharedFileDownloadListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalConnectionOpenListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalConnectionCloseListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalConnectionDataListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalNetworkingListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalNetworkingListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalNatTypeDetectionListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalPersonaDataChangedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFriendListListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFriendInvitationSendListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFriendInvitationListRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalSentFriendInvitationListRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFriendInvitationListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFriendInvitationRespondToListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFriendAddListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalFriendDeleteListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalRichPresenceChangeListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalRichPresenceListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalGameJoinRequestedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalGameInvitationReceivedListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalSendInvitationListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalUserFindListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalNotificationListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalChatRoomWithUserRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalChatRoomMessagesRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalChatRoomMessageSendListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalChatRoomMessagesListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalTelemetryEventSendListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalTelemetryEventSendListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalUserInformationRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalUserInformationRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GlobalRichPresenceRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_GameServerGlobalRichPresenceRetrieveListener(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_InitParams__SWIG_0(string jarg1, string jarg2, string jarg3, string jarg4, bool jarg5, string jarg6);

		[PreserveSig]
		public static extern IntPtr new_InitParams__SWIG_1(string jarg1, string jarg2, string jarg3, string jarg4, bool jarg5);

		[PreserveSig]
		public static extern IntPtr new_InitParams__SWIG_2(string jarg1, string jarg2, string jarg3, string jarg4);

		[PreserveSig]
		public static extern IntPtr new_InitParams__SWIG_3(string jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern IntPtr new_InitParams__SWIG_4(string jarg1, string jarg2);

		[PreserveSig]
		public static extern void InitParams_clientID_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string InitParams_clientID_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void InitParams_clientSecret_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string InitParams_clientSecret_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void InitParams_configFilePath_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string InitParams_configFilePath_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void InitParams_storagePath_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string InitParams_storagePath_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void InitParams_galaxyModulePath_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string InitParams_galaxyModulePath_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void InitParams_loadModule_set(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		public static extern bool InitParams_loadModule_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_InitParams(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_ShutdownParams(bool jarg1);

		[PreserveSig]
		public static extern void ShutdownParams_preserveStaticObjects_set(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		public static extern bool ShutdownParams_preserveStaticObjects_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_ShutdownParams(HandleRef jarg1);

		[PreserveSig]
		public static extern void Init(HandleRef jarg1);

		[PreserveSig]
		public static extern void InitGameServer(HandleRef jarg1);

		[PreserveSig]
		public static extern void Shutdown(bool jarg1);

		[PreserveSig]
		public static extern void ShutdownEx(HandleRef jarg1);

		[PreserveSig]
		public static extern void ShutdownGameServerEx(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr User();

		[PreserveSig]
		public static extern IntPtr Friends();

		[PreserveSig]
		public static extern IntPtr Chat();

		[PreserveSig]
		public static extern IntPtr Matchmaking();

		[PreserveSig]
		public static extern IntPtr Networking();

		[PreserveSig]
		public static extern IntPtr Stats();

		[PreserveSig]
		public static extern IntPtr Utils();

		[PreserveSig]
		public static extern IntPtr Apps();

		[PreserveSig]
		public static extern IntPtr Storage();

		[PreserveSig]
		public static extern IntPtr CustomNetworking();

		[PreserveSig]
		public static extern IntPtr Logger();

		[PreserveSig]
		public static extern IntPtr Telemetry();

		[PreserveSig]
		public static extern IntPtr CloudStorage();

		[PreserveSig]
		public static extern void ProcessData();

		[PreserveSig]
		public static extern void ShutdownGameServer();

		[PreserveSig]
		public static extern IntPtr GameServerUser();

		[PreserveSig]
		public static extern IntPtr GameServerMatchmaking();

		[PreserveSig]
		public static extern IntPtr GameServerNetworking();

		[PreserveSig]
		public static extern IntPtr GameServerUtils();

		[PreserveSig]
		public static extern IntPtr GameServerTelemetry();

		[PreserveSig]
		public static extern IntPtr GameServerLogger();

		[PreserveSig]
		public static extern void ProcessGameServerData();

		[PreserveSig]
		public static extern IntPtr IUnauthorizedAccessError_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IInvalidArgumentError_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IInvalidStateError_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IRuntimeError_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerOverlayVisibilityChange_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerOverlayInitializationStateChange_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerGogServicesConnectionState_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerOperationalStateChange_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerAuth_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerOtherSessionStart_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerUserData_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerSpecificUserData_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerEncryptedAppTicket_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerAccessToken_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyList_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyCreated_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyEntered_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyLeft_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyData_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyDataUpdate_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyMemberDataUpdate_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyDataRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyMemberState_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyOwnerChange_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLobbyMessage_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerUserStatsAndAchievementsRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerStatsAndAchievementsStore_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerAchievementChange_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLeaderboardsRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLeaderboardEntriesRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLeaderboardScoreUpdate_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerLeaderboardRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerUserTimePlayedRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFileShare_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerSharedFileDownload_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerConnectionOpen_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerConnectionClose_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerConnectionData_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerNetworking_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerNatTypeDetection_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerPersonaDataChanged_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerUserInformationRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFriendList_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFriendInvitationSend_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFriendInvitationListRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerSentFriendInvitationListRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFriendInvitation_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFriendInvitationRespondTo_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFriendAdd_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerFriendDelete_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerRichPresenceChange_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerRichPresence_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerRichPresenceRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerGameJoinRequested_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerGameInvitationReceived_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerSendInvitation_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerNotification_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerUserFind_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerChatRoomWithUserRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerChatRoomMessagesRetrieve_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerChatRoomMessageSend_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerChatRoomMessages_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerTelemetryEventSend_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerCloudStorageGetFileList_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerCloudStorageGetFile_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerCloudStoragePutFile_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerCloudStorageDeleteFile_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GalaxyTypeAwareListenerIsDlcOwned_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IIsDlcOwnedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IOverlayVisibilityChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IOverlayInitializationStateChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr INotificationListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IGogServicesConnectionStateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IAuthListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IOtherSessionStartListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IOperationalStateChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IUserDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ISpecificUserDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IEncryptedAppTicketListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IAccessTokenListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IPersonaDataChangedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IUserInformationRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFriendListListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFriendInvitationSendListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFriendInvitationListRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ISentFriendInvitationListRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFriendInvitationListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFriendInvitationRespondToListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFriendAddListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFriendDeleteListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IRichPresenceChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IRichPresenceListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IRichPresenceRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IGameJoinRequestedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IGameInvitationReceivedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ISendInvitationListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IUserFindListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IUserStatsAndAchievementsRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IStatsAndAchievementsStoreListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IAchievementChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILeaderboardsRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILeaderboardEntriesRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILeaderboardScoreUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILeaderboardRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IUserTimePlayedRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IFileShareListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ISharedFileDownloadListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IConnectionOpenListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IConnectionCloseListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IConnectionDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr INetworkingListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr INatTypeDetectionListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyListListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyCreatedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyEnteredListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyLeftListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyDataUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyMemberDataUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyDataRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyMemberStateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyOwnerChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ILobbyMessageListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IChatRoomWithUserRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IChatRoomMessageSendListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IChatRoomMessagesListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr IChatRoomMessagesRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ITelemetryEventSendListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ICloudStorageGetFileListListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ICloudStorageGetFileListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ICloudStoragePutFileListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr ICloudStorageDeleteFileListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalOverlayVisibilityChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalOverlayInitializationStateChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalGogServicesConnectionStateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalGogServicesConnectionStateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalAuthListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalAuthListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalOtherSessionStartListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalOperationalStateChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalOperationalStateChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalUserDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalSpecificUserDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalSpecificUserDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalEncryptedAppTicketListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalEncryptedAppTicketListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalAccessTokenListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalAccessTokenListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyListListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyCreatedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyCreatedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyEnteredListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyEnteredListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyLeftListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyLeftListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyDataUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyDataUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyMemberDataUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyMemberDataUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyDataRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyDataRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyMemberStateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyMemberStateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyOwnerChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLobbyMessageListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalLobbyMessageListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalUserStatsAndAchievementsRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalStatsAndAchievementsStoreListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalAchievementChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLeaderboardsRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLeaderboardEntriesRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLeaderboardScoreUpdateListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalLeaderboardRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalUserTimePlayedRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFileShareListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalSharedFileDownloadListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalConnectionOpenListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalConnectionCloseListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalConnectionDataListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalNetworkingListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalNetworkingListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalNatTypeDetectionListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalPersonaDataChangedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFriendListListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFriendInvitationSendListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFriendInvitationListRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalSentFriendInvitationListRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFriendInvitationListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFriendInvitationRespondToListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFriendAddListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalFriendDeleteListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalRichPresenceChangeListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalRichPresenceListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalGameJoinRequestedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalGameInvitationReceivedListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalSendInvitationListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalUserFindListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalNotificationListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalChatRoomWithUserRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalChatRoomMessagesRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalChatRoomMessageSendListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalChatRoomMessagesListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalTelemetryEventSendListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalTelemetryEventSendListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalUserInformationRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalUserInformationRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GlobalRichPresenceRetrieveListener_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr GameServerGlobalRichPresenceRetrieveListener_SWIGUpcast(IntPtr jarg1);
	}
}
