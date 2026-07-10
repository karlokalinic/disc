using System;

namespace FontSizeProfiles.BuildParts
{
	[Serializable]
	public class TextElementSettings : ElementSettings
	{
		public FontSizePerLanguage[] sizes;

		public TextElementSettings()
		{
		}

		public TextElementSettings(string newID)
		{
		}

		public TextElementSettings(string newID, int defaultSize)
		{
		}

		public TextElementSettings(string newID, FontSizePerLanguage[] fontSizePerLanguages)
		{
		}

		public float GetFontSizeForCurrentLanguage()
		{
			return 0f;
		}

		private int GetFontSizeFromLanguage(string languageCode)
		{
			return 0;
		}
	}
}
