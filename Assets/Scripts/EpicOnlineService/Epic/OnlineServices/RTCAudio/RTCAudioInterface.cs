using System;

namespace Epic.OnlineServices.RTCAudio
{
	public sealed class RTCAudioInterface : Handle
	{
		public const int AddnotifyaudiobeforerenderApiLatest = 1;

		public const int AddnotifyaudiobeforesendApiLatest = 1;

		public const int AddnotifyaudiodeviceschangedApiLatest = 1;

		public const int AddnotifyaudioinputstateApiLatest = 1;

		public const int AddnotifyaudiooutputstateApiLatest = 1;

		public const int AddnotifyparticipantupdatedApiLatest = 1;

		public const int AudiobufferApiLatest = 1;

		public const int AudioinputdeviceinfoApiLatest = 1;

		public const int AudiooutputdeviceinfoApiLatest = 1;

		public const int GetaudioinputdevicebyindexApiLatest = 1;

		public const int GetaudioinputdevicescountApiLatest = 1;

		public const int GetaudiooutputdevicebyindexApiLatest = 1;

		public const int GetaudiooutputdevicescountApiLatest = 1;

		public const int RegisterplatformaudiouserApiLatest = 1;

		public const int SendaudioApiLatest = 1;

		public const int SetaudioinputsettingsApiLatest = 1;

		public const int SetaudiooutputsettingsApiLatest = 1;

		public const int UnregisterplatformaudiouserApiLatest = 1;

		public const int UpdatereceivingApiLatest = 1;

		public const int UpdatesendingApiLatest = 1;

		public RTCAudioInterface()
		{
		}

		public RTCAudioInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyAudioBeforeRender(AddNotifyAudioBeforeRenderOptions options, object clientData, OnAudioBeforeRenderCallback completionDelegate)
		{
			return 0uL;
		}

		public ulong AddNotifyAudioBeforeSend(AddNotifyAudioBeforeSendOptions options, object clientData, OnAudioBeforeSendCallback completionDelegate)
		{
			return 0uL;
		}

		public ulong AddNotifyAudioDevicesChanged(AddNotifyAudioDevicesChangedOptions options, object clientData, OnAudioDevicesChangedCallback completionDelegate)
		{
			return 0uL;
		}

		public ulong AddNotifyAudioInputState(AddNotifyAudioInputStateOptions options, object clientData, OnAudioInputStateCallback completionDelegate)
		{
			return 0uL;
		}

		public ulong AddNotifyAudioOutputState(AddNotifyAudioOutputStateOptions options, object clientData, OnAudioOutputStateCallback completionDelegate)
		{
			return 0uL;
		}

		public ulong AddNotifyParticipantUpdated(AddNotifyParticipantUpdatedOptions options, object clientData, OnParticipantUpdatedCallback completionDelegate)
		{
			return 0uL;
		}

		public AudioInputDeviceInfo GetAudioInputDeviceByIndex(GetAudioInputDeviceByIndexOptions options)
		{
			return null;
		}

		public uint GetAudioInputDevicesCount(GetAudioInputDevicesCountOptions options)
		{
			return 0u;
		}

		public AudioOutputDeviceInfo GetAudioOutputDeviceByIndex(GetAudioOutputDeviceByIndexOptions options)
		{
			return null;
		}

		public uint GetAudioOutputDevicesCount(GetAudioOutputDevicesCountOptions options)
		{
			return 0u;
		}

		public Result RegisterPlatformAudioUser(RegisterPlatformAudioUserOptions options)
		{
			return default(Result);
		}

		public void RemoveNotifyAudioBeforeRender(ulong notificationId)
		{
		}

		public void RemoveNotifyAudioBeforeSend(ulong notificationId)
		{
		}

		public void RemoveNotifyAudioDevicesChanged(ulong notificationId)
		{
		}

		public void RemoveNotifyAudioInputState(ulong notificationId)
		{
		}

		public void RemoveNotifyAudioOutputState(ulong notificationId)
		{
		}

		public void RemoveNotifyParticipantUpdated(ulong notificationId)
		{
		}

		public Result SendAudio(SendAudioOptions options)
		{
			return default(Result);
		}

		public Result SetAudioInputSettings(SetAudioInputSettingsOptions options)
		{
			return default(Result);
		}

		public Result SetAudioOutputSettings(SetAudioOutputSettingsOptions options)
		{
			return default(Result);
		}

		public Result UnregisterPlatformAudioUser(UnregisterPlatformAudioUserOptions options)
		{
			return default(Result);
		}

		public void UpdateReceiving(UpdateReceivingOptions options, object clientData, OnUpdateReceivingCallback completionDelegate)
		{
		}

		public void UpdateSending(UpdateSendingOptions options, object clientData, OnUpdateSendingCallback completionDelegate)
		{
		}

		internal static void OnAudioBeforeRenderCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnAudioBeforeSendCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnAudioDevicesChangedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnAudioInputStateCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnAudioOutputStateCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnParticipantUpdatedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnUpdateReceivingCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnUpdateSendingCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
