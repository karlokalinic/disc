using System;

namespace LocalizationCustomSystem
{
	[Serializable]
	public class TranslationTestableFloat : TranslationFloat
	{
		public Action<string> OnTestLanguage;

		public void TestLanguage(string languageName)
		{
		}
	}
}
