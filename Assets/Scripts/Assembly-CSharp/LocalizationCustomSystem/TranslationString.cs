using System;

namespace LocalizationCustomSystem
{
	[Serializable]
	public struct TranslationString
	{
		public string Term;

		public static implicit operator string(TranslationString s)
		{
			return null;
		}

		public static implicit operator TranslationString(string term)
		{
			return default(TranslationString);
		}

		public override string ToString()
		{
			return null;
		}

		public string GetTranslatedString()
		{
			return null;
		}

		public string GetTranslatedStringToUpper()
		{
			return null;
		}

		public string GetTranslatedString(string language)
		{
			return null;
		}
	}
}
