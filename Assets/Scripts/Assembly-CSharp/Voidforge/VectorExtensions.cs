using UnityEngine;

namespace Voidforge
{
	public static class VectorExtensions
	{
		public static float Distance(this Ray ray, Ray plane)
		{
			return 0f;
		}

		public static float Distance(this Ray ray, Vector3 planePosition, Vector3 planeNormal)
		{
			return 0f;
		}

		public static float GetDuration(this AnimationCurve curve)
		{
			return 0f;
		}

		public static Line NavMeshLine(this Vector3 worldPosition, bool inverseDirection = false, float maxError = 0.05f, int layerMask = -1, Camera camera = null)
		{
			return default(Line);
		}

		public static Vector3? NavMeshPoint(this Line pointerLine, float maxError = 0.05f, int layerMask = -1, bool useLinearMethod = true)
		{
			return null;
		}

		private static Vector3? NavMeshPointRecursive(Line pointerLine, int layerMask, float breakoffRadius)
		{
			return null;
		}

		public static float Heading(this Vector2 direction)
		{
			return 0f;
		}

		public static float Heading(this Vector3 direction)
		{
			return 0f;
		}

		public static float InterceptTime(this Vector3 launchPosition, Vector3 targetPosition, Vector3 targetVelocity, float interceptorSpeed)
		{
			return 0f;
		}

		public static float Interpolate(this Vector3 barycentricCoordinates, float value0, float value1, float value2)
		{
			return 0f;
		}

		public static Vector2 Interpolate(this Vector3 barycentricCoordinates, Vector2 value0, Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		public static Vector3 Interpolate(this Vector3 barycentricCoordinates, Vector3 value0, Vector3 value1, Vector3 value2)
		{
			return default(Vector3);
		}

		public static Vector4 Interpolate(this Vector3 barycentricCoordinates, Vector4 value0, Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		public static Vector3? IntersectionPoint(this Ray ray, Ray plane)
		{
			return null;
		}

		public static Vector3? IntersectionPoint(this Ray ray, Vector3 planeOrigin, Vector3 planeNormal)
		{
			return null;
		}

		public static Vector2 InverseTransformUV(this Vector2 texCoord, Vector4 scaleOffset)
		{
			return default(Vector2);
		}

		public static bool IsZero(this float value)
		{
			return false;
		}

		public static bool IsZero(this Vector2 value)
		{
			return false;
		}

		public static bool IsZero(this Vector3 value)
		{
			return false;
		}

		public static bool IsZero(this Vector4 value)
		{
			return false;
		}

		public static Vector3 ProjectToPlane(this Vector3 point, Ray plane)
		{
			return default(Vector3);
		}

		public static Vector3 ProjectToPlane(this Vector3 point, Vector3 planeOrigin, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		public static Vector2 TransformUV(this Vector2 uv, Vector4 scaleOffset)
		{
			return default(Vector2);
		}
	}
}
