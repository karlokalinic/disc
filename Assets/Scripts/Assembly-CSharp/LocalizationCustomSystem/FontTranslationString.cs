using System;

namespace LocalizationCustomSystem
{
	[Serializable]
	public struct FontTranslationString
	{
		public string term;

		public string Term => null;

		public static implicit operator string(FontTranslationString s)
		{
			return null;
		}

		public static implicit operator FontTranslationString(string term)
		{
			return default(FontTranslationString);
		}

		public override string ToString()
		{
			return null;
		}

		public string GetTranslatedString()
		{
			return null;
		}

		public string GetTranslatedString(string language)
		{
			return null;
		}

		public static string GetFont(string baseFont)
		{
			return null;
		}
	}
}
