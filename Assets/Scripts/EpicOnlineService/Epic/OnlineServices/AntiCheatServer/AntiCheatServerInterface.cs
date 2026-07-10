using System;
using Epic.OnlineServices.AntiCheatCommon;

namespace Epic.OnlineServices.AntiCheatServer
{
	public sealed class AntiCheatServerInterface : Handle
	{
		public const int AddnotifyclientactionrequiredApiLatest = 1;

		public const int AddnotifyclientauthstatuschangedApiLatest = 1;

		public const int AddnotifymessagetoclientApiLatest = 1;

		public const int BeginsessionApiLatest = 3;

		public const int BeginsessionMaxRegistertimeout = 120;

		public const int BeginsessionMinRegistertimeout = 10;

		public const int EndsessionApiLatest = 1;

		public const int GetprotectmessageoutputlengthApiLatest = 1;

		public const int ProtectmessageApiLatest = 1;

		public const int ReceivemessagefromclientApiLatest = 1;

		public const int RegisterclientApiLatest = 1;

		public const int SetclientnetworkstateApiLatest = 1;

		public const int UnprotectmessageApiLatest = 1;

		public const int UnregisterclientApiLatest = 1;

		public AntiCheatServerInterface()
		{
		}

		public AntiCheatServerInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyClientActionRequired(AddNotifyClientActionRequiredOptions options, object clientData, OnClientActionRequiredCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyClientAuthStatusChanged(AddNotifyClientAuthStatusChangedOptions options, object clientData, OnClientAuthStatusChangedCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyMessageToClient(AddNotifyMessageToClientOptions options, object clientData, OnMessageToClientCallback notificationFn)
		{
			return 0uL;
		}

		public Result BeginSession(BeginSessionOptions options)
		{
			return default(Result);
		}

		public Result EndSession(EndSessionOptions options)
		{
			return default(Result);
		}

		public Result GetProtectMessageOutputLength(GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes)
		{
			outBufferSizeBytes = default(uint);
			return default(Result);
		}

		public Result LogEvent(LogEventOptions options)
		{
			return default(Result);
		}

		public Result LogGameRoundEnd(LogGameRoundEndOptions options)
		{
			return default(Result);
		}

		public Result LogGameRoundStart(LogGameRoundStartOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerDespawn(LogPlayerDespawnOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerRevive(LogPlayerReviveOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerSpawn(LogPlayerSpawnOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerTakeDamage(LogPlayerTakeDamageOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerTick(LogPlayerTickOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerUseAbility(LogPlayerUseAbilityOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerUseWeapon(LogPlayerUseWeaponOptions options)
		{
			return default(Result);
		}

		public Result ProtectMessage(ProtectMessageOptions options, out byte[] outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result ReceiveMessageFromClient(ReceiveMessageFromClientOptions options)
		{
			return default(Result);
		}

		public Result RegisterClient(RegisterClientOptions options)
		{
			return default(Result);
		}

		public Result RegisterEvent(RegisterEventOptions options)
		{
			return default(Result);
		}

		public void RemoveNotifyClientActionRequired(ulong notificationId)
		{
		}

		public void RemoveNotifyClientAuthStatusChanged(ulong notificationId)
		{
		}

		public void RemoveNotifyMessageToClient(ulong notificationId)
		{
		}

		public Result SetClientDetails(SetClientDetailsOptions options)
		{
			return default(Result);
		}

		public Result SetClientNetworkState(SetClientNetworkStateOptions options)
		{
			return default(Result);
		}

		public Result SetGameSessionId(SetGameSessionIdOptions options)
		{
			return default(Result);
		}

		public Result UnprotectMessage(UnprotectMessageOptions options, out byte[] outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result UnregisterClient(UnregisterClientOptions options)
		{
			return default(Result);
		}

		internal static void OnClientActionRequiredCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnClientAuthStatusChangedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnMessageToClientCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
