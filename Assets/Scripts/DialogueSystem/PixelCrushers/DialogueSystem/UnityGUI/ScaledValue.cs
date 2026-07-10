using System;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class ScaledValue
	{
		public static readonly ScaledValue zero;

		public static readonly ScaledValue max;

		public ValueScale scale;

		public float value;

		public ScaledValue(ValueScale scale, float value)
		{
		}

		public ScaledValue(ScaledValue source)
		{
		}

		public ScaledValue()
		{
		}

		public float GetPixelValue(float windowSize)
		{
			return 0f;
		}

		public static ScaledValue FromPixelValue(float value)
		{
			return null;
		}

		public static ScaledValue FromNormalizedValue(float value)
		{
			return null;
		}
	}
}
