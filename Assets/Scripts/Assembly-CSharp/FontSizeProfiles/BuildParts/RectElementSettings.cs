using System;
using UnityEngine;

namespace FontSizeProfiles.BuildParts
{
	[Serializable]
	public class RectElementSettings : ElementSettings
	{
		public Vector3 localPosition;

		public Vector2 anchoredPosition;

		public Vector2 sizeDelta;

		public RectElementSettings()
		{
		}

		public RectElementSettings(string textElementID, Vector3 localPosition, Vector2 anchoredPosition, Vector2 sizeDelta)
		{
		}
	}
}
