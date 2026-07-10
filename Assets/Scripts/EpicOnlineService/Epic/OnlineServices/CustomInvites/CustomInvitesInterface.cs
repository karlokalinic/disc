using System;

namespace Epic.OnlineServices.CustomInvites
{
	public sealed class CustomInvitesInterface : Handle
	{
		public const int AddnotifycustominviteacceptedApiLatest = 1;

		public const int AddnotifycustominvitereceivedApiLatest = 1;

		public const int FinalizeinviteApiLatest = 1;

		public const int MaxPayloadLength = 500;

		public const int SendcustominviteApiLatest = 1;

		public const int SetcustominviteApiLatest = 1;

		public CustomInvitesInterface()
		{
		}

		public CustomInvitesInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyCustomInviteAccepted(AddNotifyCustomInviteAcceptedOptions options, object clientData, OnCustomInviteAcceptedCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyCustomInviteReceived(AddNotifyCustomInviteReceivedOptions options, object clientData, OnCustomInviteReceivedCallback notificationFn)
		{
			return 0uL;
		}

		public Result FinalizeInvite(FinalizeInviteOptions options)
		{
			return default(Result);
		}

		public void RemoveNotifyCustomInviteAccepted(ulong inId)
		{
		}

		public void RemoveNotifyCustomInviteReceived(ulong inId)
		{
		}

		public void SendCustomInvite(SendCustomInviteOptions options, object clientData, OnSendCustomInviteCallback completionDelegate)
		{
		}

		public Result SetCustomInvite(SetCustomInviteOptions options)
		{
			return default(Result);
		}

		internal static void OnCustomInviteAcceptedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnCustomInviteReceivedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnSendCustomInviteCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
