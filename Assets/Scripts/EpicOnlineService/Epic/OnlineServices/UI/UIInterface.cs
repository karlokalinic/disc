using System;

namespace Epic.OnlineServices.UI
{
	public sealed class UIInterface : Handle
	{
		public const int AcknowledgecorrelationidApiLatest = 1;

		public const int AcknowledgeeventidApiLatest = 1;

		public const int AddnotifydisplaysettingsupdatedApiLatest = 1;

		public const int EventidInvalid = 0;

		public const int GetfriendsvisibleApiLatest = 1;

		public const int GettogglefriendskeyApiLatest = 1;

		public const int HidefriendsApiLatest = 1;

		public const int PrepresentApiLatest = 1;

		public const int ReportkeyeventApiLatest = 1;

		public const int SetdisplaypreferenceApiLatest = 1;

		public const int SettogglefriendskeyApiLatest = 1;

		public const int ShowfriendsApiLatest = 1;

		public UIInterface()
		{
		}

		public UIInterface(IntPtr innerHandle)
		{
		}

		public Result AcknowledgeEventId(AcknowledgeEventIdOptions options)
		{
			return default(Result);
		}

		public ulong AddNotifyDisplaySettingsUpdated(AddNotifyDisplaySettingsUpdatedOptions options, object clientData, OnDisplaySettingsUpdatedCallback notificationFn)
		{
			return 0uL;
		}

		public bool GetFriendsVisible(GetFriendsVisibleOptions options)
		{
			return false;
		}

		public NotificationLocation GetNotificationLocationPreference()
		{
			return default(NotificationLocation);
		}

		public KeyCombination GetToggleFriendsKey(GetToggleFriendsKeyOptions options)
		{
			return default(KeyCombination);
		}

		public void HideFriends(HideFriendsOptions options, object clientData, OnHideFriendsCallback completionDelegate)
		{
		}

		public bool IsValidKeyCombination(KeyCombination keyCombination)
		{
			return false;
		}

		public void RemoveNotifyDisplaySettingsUpdated(ulong id)
		{
		}

		public Result SetDisplayPreference(SetDisplayPreferenceOptions options)
		{
			return default(Result);
		}

		public Result SetToggleFriendsKey(SetToggleFriendsKeyOptions options)
		{
			return default(Result);
		}

		public void ShowFriends(ShowFriendsOptions options, object clientData, OnShowFriendsCallback completionDelegate)
		{
		}

		internal static void OnDisplaySettingsUpdatedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnHideFriendsCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnShowFriendsCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}
