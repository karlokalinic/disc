using System;
using System.Collections;
using UnityEngine;
using Voidforge;

namespace LocalizationCustomSystem
{
	[Persistent]
	public class LocalizationManager : SingletonComponent<LocalizationManager>
	{
		public static string SecondLanguage;

		public static Action OnLanguageChange;

		public static Action OnLanguageChangeDelayed;

		public static Action OnLanguageChangedInOptions;

		public static Action OnLanguagesSwitched;

		public bool DebugLogs;

		private IEnumerator languageChangeDelayedCoR;

		public static string GetCurrentLanguageName()
		{
			return null;
		}

		public static string GetCurrentLanguageCode()
		{
			return null;
		}

		public static string GetLocalizedTerm(string term, bool removeNewLines = false, bool fixForRTL = true)
		{
			return null;
		}

		public static string GetLocalizedTermToUpper(string term, bool removeNewLines = false)
		{
			return null;
		}

		public static string GetLocalizedTerm(string term, string languageName)
		{
			return null;
		}

		public static string GetLocalizedTermAsideChinese(string term)
		{
			return null;
		}

		public static Sprite GetLocalizedSprite(string term)
		{
			return null;
		}

		public static Font GetLocalizedFont(string term)
		{
			return null;
		}

		public static Material GetLocalizedMaterial(string term)
		{
			return null;
		}

		public static void ToggleLanguage()
		{
		}

		public static void SetLanguage(string languageName)
		{
		}

		public static void InvokeDelayedLanguageChange()
		{
		}

		private IEnumerator DelayedLanguageChangeInvoke()
		{
			return null;
		}

		public static bool IsRightToLeftText()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
