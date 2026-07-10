using System;

namespace FontSizeProfiles
{
	[Serializable]
	public class AutoFontSizePerLanguage
	{
		public string languageCode;

		public int minFontSize;

		public int maxFontSize;

		public AutoFontSizePerLanguage()
		{
		}

		public AutoFontSizePerLanguage(int minDefaultSize, int maxDefaultSize)
		{
		}

		public AutoFontSizePerLanguage(string languageCode, int minDefaultSize, int maxDefaultSize)
		{
		}
	}
}
