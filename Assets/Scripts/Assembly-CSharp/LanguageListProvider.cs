using System.Collections.Generic;
using LocalizationCustomSystem;

public static class LanguageListProvider
{
	private const int defaultIndex = 0;

	private static List<string> allLanguages;

	private static List<string> availableLanguages;

	private static List<LocalizationOption> localizationOptions;

	public static List<string> Languages => null;

	public static List<LocalizationOption> LocalizationOptions => null;

	public static int GetSavedLanguage(string settingName)
	{
		return 0;
	}

	public static void SaveLanguage(string settingName, int indexToSave)
	{
	}

	private static void Init()
	{
	}
}
