using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal static class NativeMethods
	{
		[PreserveSig]
		public static extern bool SteamAPI_Init();

		[PreserveSig]
		public static extern void SteamAPI_Shutdown();

		[PreserveSig]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[PreserveSig]
		public static extern int SteamAPI_GetHSteamPipe();

		[PreserveSig]
		public static extern int SteamAPI_GetHSteamUser();

		[PreserveSig]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_Init();

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg);

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamPipe();

		[PreserveSig]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		[PreserveSig]
		public static extern ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle);

		[PreserveSig]
		public static extern ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex);

		[PreserveSig]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo);

		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamRunningOnSteamDeck(IntPtr instancePtr);
	}
}
