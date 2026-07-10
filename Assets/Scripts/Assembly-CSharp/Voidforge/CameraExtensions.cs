using UnityEngine;

namespace Voidforge
{
	public static class CameraExtensions
	{
		public static float Distance(this Camera camera, Vector3 worldPoint)
		{
			return 0f;
		}

		public static float Distance(this Camera camera, Vector3 worldPoint, out float sign)
		{
			sign = default(float);
			return 0f;
		}

		public static bool IsVisible(this Camera camera, Vector3 worldPoint)
		{
			return false;
		}

		public static bool IsVisible(this Camera camera, Vector3 worldPoint, out BitArray32 outside)
		{
			outside = default(BitArray32);
			return false;
		}

		public static bool IsVisible(this Camera camera, Bounds bounds)
		{
			return false;
		}

		public static Bounds WorldToScreenBounds(this Camera camera, Bounds bounds)
		{
			return default(Bounds);
		}

		public static Bounds WorldToViewportBounds(this Camera camera, Bounds bounds)
		{
			return default(Bounds);
		}
	}
}
