using System;

namespace FontSizeProfiles.BuildParts
{
	[Serializable]
	public class RectElementHorizontalSettings : ElementSettings
	{
		public float anchoredPositionX;

		public float sizeDeltaX;

		public RectElementHorizontalSettings()
		{
		}

		public RectElementHorizontalSettings(string textElementID, float anchoredPositionX, float sizeDeltaX)
		{
		}
	}
}
