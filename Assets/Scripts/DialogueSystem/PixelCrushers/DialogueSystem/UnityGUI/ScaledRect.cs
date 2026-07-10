using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class ScaledRect
	{
		public static readonly ScaledRect empty;

		public static readonly ScaledRect wholeScreen;

		public ScaledRectAlignment origin;

		public ScaledRectAlignment alignment;

		public ScaledValue x;

		public ScaledValue y;

		public ScaledValue width;

		public ScaledValue height;

		public float minPixelWidth;

		public float minPixelHeight;

		public ScaledRect(ScaledRectAlignment origin, ScaledRectAlignment alignment, ScaledValue x, ScaledValue y, ScaledValue width, ScaledValue height, float minPixelWidth = 0f, float minPixelHeight = 0f)
		{
		}

		public ScaledRect(ScaledRect source)
		{
		}

		public ScaledRect()
		{
		}

		public static ScaledRect FromOrigin(ScaledRectAlignment origin, ScaledValue width, ScaledValue height, float minPixelWidth = 0f, float minPixelHeight = 0f)
		{
			return null;
		}

		public Rect GetPixelRect()
		{
			return default(Rect);
		}

		public Rect GetPixelRect(Vector2 windowSize)
		{
			return default(Rect);
		}

		public Rect GetPixelRect(Vector2 windowSize, Vector2 defaultSize)
		{
			return default(Rect);
		}

		private Vector2 GetPixelOrigin(Vector2 windowSize)
		{
			return default(Vector2);
		}

		private Vector2 GetAlignmentFactor()
		{
			return default(Vector2);
		}
	}
}
