using System;

namespace LocalizationCustomSystem
{
	[Serializable]
	public struct MaterialTranslationString
	{
		public string term;

		public string Term => null;

		public static implicit operator string(MaterialTranslationString s)
		{
			return null;
		}

		public static implicit operator MaterialTranslationString(string term)
		{
			return default(MaterialTranslationString);
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

		public static string GetMaterial(string baseMaterial)
		{
			return null;
		}
	}
}
