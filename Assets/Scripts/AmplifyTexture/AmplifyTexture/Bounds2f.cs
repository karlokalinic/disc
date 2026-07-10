using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	internal sealed class Bounds2f
	{
		private static Vector2 empty_min;

		private static Vector2 empty_max;

		internal Vector2 min;

		internal Vector2 max;

		internal float X => 0f;

		internal float Y => 0f;

		internal float Width => 0f;

		internal float Height => 0f;

		internal Bounds2f()
		{
		}

		internal Bounds2f(Bounds2f bounds)
		{
		}

		internal Bounds2f(Vector2 min, Vector2 max)
		{
		}

		internal Bounds2f(int x, int y, int width, int height)
		{
		}

		internal void Clear()
		{
		}

		internal bool IsEmpty()
		{
			return false;
		}

		internal void AddPoint(float x, float y)
		{
		}

		internal void AddRect(Rect rect)
		{
		}

		internal void AddBounds(Bounds2f bounds)
		{
		}

		internal void Expand(float x, float y)
		{
		}

		internal void Translate(Vector2 offset)
		{
		}

		internal bool Overlaps(Bounds2f bounds)
		{
			return false;
		}

		internal Rect ToRect()
		{
			return default(Rect);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
