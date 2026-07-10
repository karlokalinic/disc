namespace CollageMode
{
	public class CollageModePersister
	{
		private struct OperationsSetSave
		{
			public bool[] IsFavoruite;
		}

		private const SETTINGS_CATEGORY _CATEGORY = SETTINGS_CATEGORY.COLLAGE_MODE;

		private const string _HIDDEN_IMAGE_UNLOCKED_AND_SEEN_STATE_COMMUNIST = "HiddenImage_UnlockedAndSeenState_COMMUNIST";

		private const string _HIDDEN_IMAGE_UNLOCKED_AND_SEEN_STATE_FASCIST = "HiddenImage_UnlockedAndSeenState_FASCIST";

		private const string _HIDDEN_IMAGE_UNLOCKED_AND_SEEN_STATE_MORALIST = "HiddenImage_UnlockedAndSeenState_MORALIST";

		private const string _HIDDEN_IMAGE_UNLOCKED_AND_SEEN_STATE_ULTRALIBERAL = "HiddenImage_UnlockedAndSeenState_ULTRALIBERAL";

		private const string _HIDDEN_IMAGE_UNLOCKED_STATE = "HiddenImage_UnlockedState_";

		private const string _FRAGMENTS_TAB_UNLOCKED_STATE = "FragmentsTab_UnlockedState";

		private const string _CONTENT_POLICY_ACCEPTED = "ContentPolicy_Accepted";

		private const string _SPOILER_WARNING_ACCEPTED = "SpoilerWarning_Accepted";

		private const string _OPERATIONS_SET = "OperationsSet_";

		public static bool GetHiddenImageUnlocked(string hiddenImageID)
		{
			return false;
		}

		public static void SetHiddenImageUnlocked(string hiddenImageID)
		{
		}

		public static void SetHiddenImageLocked(string hiddenImageID)
		{
		}

		public static bool GetFragmentsTabUnlocked()
		{
			return false;
		}

		public static void SetFragmentsTabUnlocked()
		{
		}

		public static bool GetContentPolicyAccepted()
		{
			return false;
		}

		public static void SetContentPolicyAccepted(bool isAccepted)
		{
		}

		public static bool GetSpoilerWarningAccepted()
		{
			return false;
		}

		public static void SetSpoilerWarningAccepted(bool isAccepted)
		{
		}

		public static void SaveOperationSetFavoruites(BaseOperationsSet operationsSet)
		{
		}

		public static void LoadOperationSetFavoruites(BaseOperationsSet operationsSet)
		{
		}

		private static int GetIntOrDefaultStat(string key)
		{
			return 0;
		}

		private static bool GetBoolOrDefault(string key)
		{
			return false;
		}

		private static string GetStringOrDefault(string key)
		{
			return null;
		}

		private static void SetInt(string key, int value, bool save = false)
		{
		}

		private static void SetBool(string key, bool value, bool save = true)
		{
		}

		private static void SetString(string key, string value, bool save = true)
		{
		}

		public static void SetCompleteHiddenImageSeen(string shortTerm)
		{
		}

		private static bool SetKeyToUnlockedIfContainsShortTerm(string keyToUnlock, string shortTermInside)
		{
			return false;
		}

		public static bool AllCompletedHiddenImagesSeen()
		{
			return false;
		}
	}
}
