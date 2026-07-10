using System;

namespace LocalizationCustomSystem
{
	[Serializable]
	public class TranslationFloat
	{
		public float[] floatValues;

		public string[] languagesNames;

		private static string DefaultLanguageCode => null;

		public float GetLocalizedFloat()
		{
			return 0f;
		}

		public float GetLocalizedFloat(string languageCode)
		{
			return 0f;
		}
	}
}
