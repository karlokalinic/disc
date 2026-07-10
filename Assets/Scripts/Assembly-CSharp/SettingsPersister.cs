using System;
using System.Collections;
using System.Collections.Generic;

public static class SettingsPersister
{
	private static class SettingsHolder
	{
		private static Dictionary<SETTINGS_CATEGORY, Dictionary<string, SettingsValue>> settingsMap;

		private static Dictionary<SETTINGS_CATEGORY, Dictionary<string, SettingsValue>> previewSettings;

		private static Dictionary<SETTINGS_CATEGORY, Dictionary<string, SettingsValue>> backupSettingsMap;

		private static string ErrorMessage => null;

		private static IEnumerator RefreshSettingsFromDisk(bool canRead)
		{
			return null;
		}

		public static Dictionary<SETTINGS_CATEGORY, Dictionary<string, SettingsValue>> Get()
		{
			return null;
		}

		public static IEnumerator ReadGameSettingsCoR()
		{
			return null;
		}

		public static void ResetSettings()
		{
		}

		public static void PreviewReset()
		{
		}

		public static void CancelPreview()
		{
		}
	}

	public static Action OnSettingsInitialized;

	public const string SETTINGS_DIRECTORY = "Settings";

	public const string SETTINGS_FILE = "Settings.json";

	private static bool hasSettingsFile;

	public static IEnumerator ReadSettingsCoR()
	{
		return null;
	}

	public static bool DoesSettingsHaveLanguage()
	{
		return false;
	}

	public static int GetLanguageIndex()
	{
		return 0;
	}

	public static string GetLanguageName()
	{
		return null;
	}

	public static string GetSettingsFilepath()
	{
		return null;
	}

	public static bool DoesSettingsFileExist()
	{
		return false;
	}

	public static void ResetSettings()
	{
	}

	public static void PreviewResetSettings()
	{
	}

	public static void CancelPreviewSettings()
	{
	}

	public static void Save(bool immediateSave = false, int timeout = 0)
	{
	}

	public static void ImmediateSave()
	{
	}

	public static void SaveData()
	{
	}

	public static IEnumerator SaveDataCoR()
	{
		return null;
	}

	private static bool HasField(SETTINGS_CATEGORY settingsCategory, string fieldName)
	{
		return false;
	}

	public static bool DeleteField(SETTINGS_CATEGORY settingsCategory, string fieldName)
	{
		return false;
	}

	public static float GetFloatOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, float defaultValue)
	{
		return 0f;
	}

	public static void SetFloat(SETTINGS_CATEGORY settingsCategory, string fieldName, float value)
	{
	}

	public static string GetStringOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, string defaultValue)
	{
		return null;
	}

	public static void SetString(SETTINGS_CATEGORY settingsCategory, string fieldName, string value)
	{
	}

	public static int GetIntOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, int defaultValue)
	{
		return 0;
	}

	public static void SetInt(SETTINGS_CATEGORY settingsCategory, string fieldName, int value)
	{
	}

	public static bool GetBoolOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, bool defaultValue)
	{
		return false;
	}

	public static void SetBool(SETTINGS_CATEGORY settingsCategory, string fieldName, bool value)
	{
	}

	private static float FloatOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, float value, bool overWrite)
	{
		return 0f;
	}

	private static string StringOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, string value, bool overWrite)
	{
		return null;
	}

	private static int IntOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, int value, bool overWrite)
	{
		return 0;
	}

	private static bool BoolOrDefault(SETTINGS_CATEGORY settingsCategory, string fieldName, bool value, bool overWrite)
	{
		return false;
	}
}
