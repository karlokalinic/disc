using UnityEngine;

namespace InControl
{
	public static class Utility
	{
		public const float Epsilon = 1E-07f;

		private static readonly Vector2[] circleVertexList;

		internal static bool Is32Bit => false;

		internal static bool Is64Bit => false;

		public static void DrawCircleGizmo(Vector2 center, float radius)
		{
		}

		public static void DrawCircleGizmo(Vector2 center, float radius, Color color)
		{
		}

		public static void DrawOvalGizmo(Vector2 center, Vector2 size)
		{
		}

		public static void DrawOvalGizmo(Vector2 center, Vector2 size, Color color)
		{
		}

		public static void DrawRectGizmo(Rect rect)
		{
		}

		public static void DrawRectGizmo(Rect rect, Color color)
		{
		}

		public static void DrawRectGizmo(Vector2 center, Vector2 size)
		{
		}

		public static void DrawRectGizmo(Vector2 center, Vector2 size, Color color)
		{
		}

		public static bool GameObjectIsCulledOnCurrentCamera(GameObject gameObject)
		{
			return false;
		}

		public static Color MoveColorTowards(Color color0, Color color1, float maxDelta)
		{
			return default(Color);
		}

		public static float ApplyDeadZone(float value, float lowerDeadZone, float upperDeadZone)
		{
			return 0f;
		}

		public static float ApplySmoothing(float thisValue, float lastValue, float deltaTime, float sensitivity)
		{
			return 0f;
		}

		public static float ApplySnapping(float value, float threshold)
		{
			return 0f;
		}

		internal static bool TargetIsButton(InputControlType target)
		{
			return false;
		}

		internal static bool TargetIsStandard(InputControlType target)
		{
			return false;
		}

		internal static bool TargetIsAlias(InputControlType target)
		{
			return false;
		}

		public static string ReadFromFile(string path)
		{
			return null;
		}

		public static void WriteToFile(string path, string data)
		{
		}

		public static float Abs(float value)
		{
			return 0f;
		}

		public static bool Approximately(float v1, float v2)
		{
			return false;
		}

		public static bool Approximately(Vector2 v1, Vector2 v2)
		{
			return false;
		}

		public static bool IsNotZero(float value)
		{
			return false;
		}

		public static bool IsZero(float value)
		{
			return false;
		}

		public static int Sign(float f)
		{
			return 0;
		}

		public static bool AbsoluteIsOverThreshold(float value, float threshold)
		{
			return false;
		}

		public static float NormalizeAngle(float angle)
		{
			return 0f;
		}

		public static float VectorToAngle(Vector2 vector)
		{
			return 0f;
		}

		public static float Min(float v0, float v1)
		{
			return 0f;
		}

		public static float Max(float v0, float v1)
		{
			return 0f;
		}

		public static float Min(float v0, float v1, float v2, float v3)
		{
			return 0f;
		}

		public static float Max(float v0, float v1, float v2, float v3)
		{
			return 0f;
		}

		internal static float ValueFromSides(float negativeSide, float positiveSide)
		{
			return 0f;
		}

		internal static float ValueFromSides(float negativeSide, float positiveSide, bool invertSides)
		{
			return 0f;
		}

		public static void ArrayResize<T>(ref T[] array, int capacity)
		{
		}

		public static void ArrayExpand<T>(ref T[] array, int capacity)
		{
		}

		public static void ArrayAppend<T>(ref T[] array, T item)
		{
		}

		public static void ArrayAppend<T>(ref T[] array, T[] items)
		{
		}

		public static int NextPowerOfTwo(int value)
		{
			return 0;
		}

		public static string GetPlatformName(bool uppercase = true)
		{
			return null;
		}

		private static string GetHumanUnderstandableWindowsVersion()
		{
			return null;
		}

		public static string GetWindowsVersion()
		{
			return null;
		}

		public static int GetSystemBuildNumber()
		{
			return 0;
		}

		public static void LoadScene(string sceneName)
		{
		}

		internal static string PluginFileExtension()
		{
			return null;
		}
	}
}
