using UnityEngine;

public static class ShapesDrawer
{
	private static Texture2D aaLineTex;

	private static Texture2D lineTex;

	private static Material blitMaterial;

	private static Material blendMaterial;

	private static Rect lineRect;

	public static void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width, bool antiAlias)
	{
	}

	public static void DrawCircle(Vector2 center, int radius, Color color, float width, int segmentsPerQuarter)
	{
	}

	public static void DrawCircle(Vector2 center, int radius, Color color, float width, bool antiAlias, int segmentsPerQuarter)
	{
	}

	public static void DrawBezierLine(Vector2 start, Vector2 startTangent, Vector2 end, Vector2 endTangent, Color color, float width, bool antiAlias, int segments)
	{
	}

	private static Vector2 CubeBezier(Vector2 s, Vector2 st, Vector2 e, Vector2 et, float t)
	{
		return default(Vector2);
	}

	static ShapesDrawer()
	{
	}

	private static void Initialize()
	{
	}
}
