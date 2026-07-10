using UnityEngine.Networking;

namespace TwitchIntegration.Utilities
{
	public static class TwitchStrings
	{
		public static class Errors
		{
			internal const string ERR_NO_ACTIVE_DIALOGUE_POLL = "ERR_NO_ACTIVE_DIALOGUE_POLL";

			internal const string ERR_NO_CHANNEL_ID = "ERR_NO_CHANNEL_ID";

			public static bool IsNoChannelError(string error)
			{
				return false;
			}
		}

		internal const string AUTHORIZATION = "Authorization";

		internal const string CHANNEL_SECRET_HEADER = "x-disco-elysium-channel-secret";

		internal const string GAME_VERSION_HEADER = "x-disco-elysium-game-version";

		internal const string GAME_VERSION = "1.337";

		private const string DEBUG_TWITCH_CHANNEL_ID_HEADER = "x-debug-twitch-channel-id";

		private const bool USE_SIR_MAC_ID = true;

		private const string DEBUG_TWITCH_CHANNEL_ID_SIR_MAC = "DEV_SIR_MAC";

		private const string DEBUG_TWITCH_CHANNEL_SECRET_MAC = "superSecretKeySsshh";

		private const string DEBUG_TWITCH_CHANNEL_ID_VICTOR = "DEV_SIR_VICTOR";

		private const string DEBUG_TWITCH_CHANNEL_SECRET_VICTOR = "thisIsSupposedToBeSecret";

		internal static string GetAuthorizationWebToken(string token)
		{
			return null;
		}

		internal static void AddTwitchAuthorizationToken(this UnityWebRequest request, string token)
		{
		}

		internal static void AddTwitchChannelSecret(this UnityWebRequest request, string secret)
		{
		}

		internal static void AddGameVersion(this UnityWebRequest request)
		{
		}

		internal static void AddDebugTwitchChannelID(this UnityWebRequest request)
		{
		}

		internal static void AddDebugTwitchChannelSecret(this UnityWebRequest request)
		{
		}

		internal static string GetDebugChannelID()
		{
			return null;
		}

		internal static string GetDebugChannelSECRET()
		{
			return null;
		}
	}
}
