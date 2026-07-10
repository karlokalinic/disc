using System;
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
using Epic.OnlineServices.Metrics;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.ProgressionSnapshot;
using Epic.OnlineServices.RTC;
using Epic.OnlineServices.RTCAdmin;
using Epic.OnlineServices.Reports;
using Epic.OnlineServices.Sanctions;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;
using Epic.OnlineServices.UserInfo;

namespace Epic.OnlineServices.Platform
{
	public sealed class PlatformInterface : Handle
	{
		public const int AndroidinitializeoptionssysteminitializeoptionsApiLatest = 2;

		public const int CountrycodeMaxBufferLen = 5;

		public const int CountrycodeMaxLength = 4;

		public const int InitializeApiLatest = 4;

		public const int InitializeThreadaffinityApiLatest = 1;

		public const int LocalecodeMaxBufferLen = 10;

		public const int LocalecodeMaxLength = 9;

		public const int OptionsApiLatest = 11;

		public const int RtcoptionsApiLatest = 1;

		public const int PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest = 1;

		public static Result Initialize(AndroidInitializeOptions options)
		{
			return default(Result);
		}

		public PlatformInterface()
		{
		}

		public PlatformInterface(IntPtr innerHandle)
		{
		}

		public Result CheckForLauncherAndRestart()
		{
			return default(Result);
		}

		public static PlatformInterface Create(Options options)
		{
			return null;
		}

		public AchievementsInterface GetAchievementsInterface()
		{
			return null;
		}

		public Result GetActiveCountryCode(EpicAccountId localUserId, out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result GetActiveLocaleCode(EpicAccountId localUserId, out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public AntiCheatClientInterface GetAntiCheatClientInterface()
		{
			return null;
		}

		public AntiCheatServerInterface GetAntiCheatServerInterface()
		{
			return null;
		}

		public AuthInterface GetAuthInterface()
		{
			return null;
		}

		public ConnectInterface GetConnectInterface()
		{
			return null;
		}

		public CustomInvitesInterface GetCustomInvitesInterface()
		{
			return null;
		}

		public EcomInterface GetEcomInterface()
		{
			return null;
		}

		public FriendsInterface GetFriendsInterface()
		{
			return null;
		}

		public KWSInterface GetKWSInterface()
		{
			return null;
		}

		public LeaderboardsInterface GetLeaderboardsInterface()
		{
			return null;
		}

		public LobbyInterface GetLobbyInterface()
		{
			return null;
		}

		public MetricsInterface GetMetricsInterface()
		{
			return null;
		}

		public ModsInterface GetModsInterface()
		{
			return null;
		}

		public Result GetOverrideCountryCode(out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result GetOverrideLocaleCode(out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public P2PInterface GetP2PInterface()
		{
			return null;
		}

		public PlayerDataStorageInterface GetPlayerDataStorageInterface()
		{
			return null;
		}

		public PresenceInterface GetPresenceInterface()
		{
			return null;
		}

		public ProgressionSnapshotInterface GetProgressionSnapshotInterface()
		{
			return null;
		}

		public RTCAdminInterface GetRTCAdminInterface()
		{
			return null;
		}

		public RTCInterface GetRTCInterface()
		{
			return null;
		}

		public ReportsInterface GetReportsInterface()
		{
			return null;
		}

		public SanctionsInterface GetSanctionsInterface()
		{
			return null;
		}

		public SessionsInterface GetSessionsInterface()
		{
			return null;
		}

		public StatsInterface GetStatsInterface()
		{
			return null;
		}

		public TitleStorageInterface GetTitleStorageInterface()
		{
			return null;
		}

		public UIInterface GetUIInterface()
		{
			return null;
		}

		public UserInfoInterface GetUserInfoInterface()
		{
			return null;
		}

		public static Result Initialize(InitializeOptions options)
		{
			return default(Result);
		}

		public void Release()
		{
		}

		public Result SetOverrideCountryCode(string newCountryCode)
		{
			return default(Result);
		}

		public Result SetOverrideLocaleCode(string newLocaleCode)
		{
			return default(Result);
		}

		public static Result Shutdown()
		{
			return default(Result);
		}

		public void Tick()
		{
		}

		public static PlatformInterface Create(WindowsOptions options)
		{
			return null;
		}
	}
}
