using System;

namespace FontSizeProfiles.BuildParts
{
	[Serializable]
	public class RectElementHeightSettings : ElementSettings
	{
		public float height;

		public RectElementHeightSettings()
		{
		}

		public RectElementHeightSettings(string textElementID, float height)
		{
		}
	}
}
