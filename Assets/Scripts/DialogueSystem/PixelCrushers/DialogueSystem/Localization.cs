using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class Localization
	{
		private static string m_language;

		private static int m_currentLanguageID;

		private static bool m_useDefaultIfUndefined;

		public static string language
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool isDefaultLanguage => false;

		public static bool useDefaultIfUndefined
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string Language
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsDefaultLanguage => false;

		public static bool UseDefaultIfUndefined
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int GetCurrentLanguageID(TextTable textTable)
		{
			return 0;
		}

		public static string GetLanguage(SystemLanguage systemLanguage)
		{
			return null;
		}
	}
}
