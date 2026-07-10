using System;
using Epic.OnlineServices.RTCAudio;

namespace Epic.OnlineServices.RTC
{
	public sealed class RTCInterface : Handle
	{
		public const int AddnotifydisconnectedApiLatest = 1;

		public const int AddnotifyparticipantstatuschangedApiLatest = 1;

		public const int BlockparticipantApiLatest = 1;

		public const int JoinroomApiLatest = 1;

		public const int LeaveroomApiLatest = 1;

		public const int ParticipantmetadataApiLatest = 1;

		public const int ParticipantmetadataKeyMaxcharcount = 256;

		public const int ParticipantmetadataValueMaxcharcount = 256;

		public const int SetroomsettingApiLatest = 1;

		public const int SetsettingApiLatest = 1;

		public RTCInterface()
		{
		}

		public RTCInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyDisconnected(AddNotifyDisconnectedOptions options, object clientData, OnDisconnectedCallback completionDelegate)
		{
			return 0uL;
		}

		public ulong AddNotifyParticipantStatusChanged(AddNotifyParticipantStatusChangedOptions options, object clientData, OnParticipantStatusChangedCallback completionDelegate)
		{
			return 0uL;
		}

		public void BlockParticipant(BlockParticipantOptions options, object clientData, OnBlockParticipantCallback completionDelegate)
		{
		}

		public RTCAudioInterface GetAudioInterface()
		{
			return null;
		}

		public void JoinRoom(JoinRoomOptions options, object clientData, OnJoinRoomCallback completionDelegate)
		{
		}

		public void LeaveRoom(LeaveRoomOptions options, object clientData, OnLeaveRoomCallback completionDelegate)
		{
		}

		public void RemoveNotifyDisconnected(ulong notificationId)
		{
		}

		public void RemoveNotifyParticipantStatusChanged(ulong notificationId)
		{
		}

		public Result SetRoomSetting(SetRoomSettingOptions options)
		{
			return default(Result);
		}

		public Result SetSetting(SetSettingOptions options)
		{
			return default(Result);
		}

		internal static void OnBlockParticipantCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnDisconnectedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnJoinRoomCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnLeaveRoomCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnParticipantStatusChangedCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
