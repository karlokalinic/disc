using System;

namespace FontSizeProfiles
{
	[Serializable]
	public class FontSizePerLanguage
	{
		public string languageCode;

		public int fontSize;

		public FontSizePerLanguage()
		{
		}

		public FontSizePerLanguage(int defaultSize)
		{
		}

		public FontSizePerLanguage(int defaultSize, string langCode)
		{
		}

		public FontSizePerLanguage(string langCode, int defaultSize)
		{
		}
	}
}
