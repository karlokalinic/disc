using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	internal sealed class Bounds2i
	{
		private static Point empty_min;

		private static Point empty_max;

		internal Point min;

		internal Point max;

		internal float X => 0f;

		internal float Y => 0f;

		internal float Width => 0f;

		internal float Height => 0f;

		internal Bounds2i()
		{
		}

		internal Bounds2i(Bounds2i bounds)
		{
		}

		internal Bounds2i(Point min, Point max)
		{
		}

		internal Bounds2i(int x, int y, int width, int height)
		{
		}

		internal void Clear()
		{
		}

		internal bool IsEmpty()
		{
			return false;
		}

		internal void AddPoint(int x, int y)
		{
		}

		internal void AddRect(Rectangle rect)
		{
		}

		internal void AddBounds(Bounds2i bounds)
		{
		}

		internal void Expand(int x, int y)
		{
		}

		internal void Translate(Point offset)
		{
		}

		internal bool Overlaps(Bounds2i bounds)
		{
			return false;
		}

		internal bool Contains(int x, int y)
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
