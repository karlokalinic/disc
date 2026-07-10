using UnityEngine;

namespace Voidforge
{
	public static class ColorConversion
	{
		private static Color GetColor(float hue, float saturation, float value, float alpha)
		{
			return default(Color);
		}

		public static Color32 ParseColor(this string colorText)
		{
			return default(Color32);
		}

		public static string ToHex(this Color32 color)
		{
			return null;
		}

		public static string ToHex(Color color)
		{
			return null;
		}

		private static Vector4 ToHSVA(this Color color)
		{
			return default(Vector4);
		}

		public static Color ToColor(this Vector4 hsva)
		{
			return default(Color);
		}

		public static Color32[] ToPixels(this Color color, int dimensions)
		{
			return null;
		}

		public static Color32[] ToPixels(this Color color, int width, int height)
		{
			return null;
		}

		public static Color32[] ToPixels(this Color32 color, int dimensions)
		{
			return null;
		}

		private static Color32[] ToPixels(this Color32 color, int width, int height)
		{
			return null;
		}

		public static Color32[] ToPixels(this Texture2D texture, int width, int height)
		{
			return null;
		}

		public static Texture2D ToTexture(this Color32[] pixels, int width, TextureFormat format = TextureFormat.ARGB32, bool mipmap = true, bool linear = false)
		{
			return null;
		}

		public static Color WithAlpha(this Color color, float value, bool relative = false)
		{
			return default(Color);
		}

		public static Color WithRed(this Color color, float value, bool relative = false)
		{
			return default(Color);
		}

		public static Color WithGreen(this Color color, float value, bool relative = false)
		{
			return default(Color);
		}

		public static Color WithBlue(this Color color, float value, bool relative = false)
		{
			return default(Color);
		}

		public static Color WithHue(this Color color, float value, bool relative = false)
		{
			return default(Color);
		}
	}
}
