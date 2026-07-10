using System;

namespace Epic.OnlineServices.AntiCheatClient
{
	public sealed class AntiCheatClientInterface : Handle
	{
		public const int AddexternalintegritycatalogApiLatest = 1;

		public const int AddnotifymessagetopeerApiLatest = 1;

		public const int AddnotifymessagetoserverApiLatest = 1;

		public const int AddnotifypeeractionrequiredApiLatest = 1;

		public const int AddnotifypeerauthstatuschangedApiLatest = 1;

		public const int BeginsessionApiLatest = 3;

		public const int EndsessionApiLatest = 1;

		public const int GetprotectmessageoutputlengthApiLatest = 1;

		public IntPtr PeerSelf;

		public const int PollstatusApiLatest = 1;

		public const int ProtectmessageApiLatest = 1;

		public const int ReceivemessagefrompeerApiLatest = 1;

		public const int ReceivemessagefromserverApiLatest = 1;

		public const int RegisterpeerApiLatest = 1;

		public const int UnprotectmessageApiLatest = 1;

		public const int UnregisterpeerApiLatest = 1;

		public AntiCheatClientInterface()
		{
		}

		public AntiCheatClientInterface(IntPtr innerHandle)
		{
		}

		public Result AddExternalIntegrityCatalog(AddExternalIntegrityCatalogOptions options)
		{
			return default(Result);
		}

		public ulong AddNotifyMessageToPeer(AddNotifyMessageToPeerOptions options, object clientData, OnMessageToPeerCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyMessageToServer(AddNotifyMessageToServerOptions options, object clientData, OnMessageToServerCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyPeerActionRequired(AddNotifyPeerActionRequiredOptions options, object clientData, OnPeerActionRequiredCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyPeerAuthStatusChanged(AddNotifyPeerAuthStatusChangedOptions options, object clientData, OnPeerAuthStatusChangedCallback notificationFn)
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

		public Result PollStatus(PollStatusOptions options, out AntiCheatClientViolationType outViolationType, out string outMessage)
		{
			outViolationType = default(AntiCheatClientViolationType);
			outMessage = null;
			return default(Result);
		}

		public Result ProtectMessage(ProtectMessageOptions options, out byte[] outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result ReceiveMessageFromPeer(ReceiveMessageFromPeerOptions options)
		{
			return default(Result);
		}

		public Result ReceiveMessageFromServer(ReceiveMessageFromServerOptions options)
		{
			return default(Result);
		}

		public Result RegisterPeer(RegisterPeerOptions options)
		{
			return default(Result);
		}

		public void RemoveNotifyMessageToPeer(ulong notificationId)
		{
		}

		public void RemoveNotifyMessageToServer(ulong notificationId)
		{
		}

		public void RemoveNotifyPeerActionRequired(ulong notificationId)
		{
		}

		public void RemoveNotifyPeerAuthStatusChanged(ulong notificationId)
		{
		}

		public Result UnprotectMessage(UnprotectMessageOptions options, out byte[] outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result UnregisterPeer(UnregisterPeerOptions options)
		{
			return default(Result);
		}

		internal static void OnMessageToPeerCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnMessageToServerCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnPeerActionRequiredCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnPeerAuthStatusChangedCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
