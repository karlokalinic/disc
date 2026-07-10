using System;
using UnityEngine;

namespace FontSizeProfiles.BuildParts
{
	[Serializable]
	public class AutoTextElementSettings : ElementSettings
	{
		public AutoFontSizePerLanguage[] sizes;

		public AutoTextElementSettings()
		{
		}

		public AutoTextElementSettings(string newID)
		{
		}

		public AutoTextElementSettings(string newID, int maxDefaultSize)
		{
		}

		public AutoTextElementSettings(string newID, int minDefaultSize, int maxDefaultSize)
		{
		}

		public AutoTextElementSettings(string newID, AutoFontSizePerLanguage autoFontSizePerLanguage)
		{
		}

		public AutoTextElementSettings(string newID, AutoFontSizePerLanguage[] autoFontSizePerLanguages)
		{
		}

		public Vector2 GetFontSizeForCurrentLanguage()
		{
			return default(Vector2);
		}

		private Vector2 GetFontMinMaxSizeFromLanguage(string languageCode)
		{
			return default(Vector2);
		}
	}
}
