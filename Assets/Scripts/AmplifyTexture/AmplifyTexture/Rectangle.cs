using System;

namespace AmplifyTexture
{
	[Serializable]
	public class Rectangle
	{
		public int x;

		public int y;

		public int width;

		public int height;

		public int Left => 0;

		public int Top => 0;

		public int Right => 0;

		public int Bottom => 0;

		public Rectangle()
		{
		}

		public Rectangle(int x, int y, int width, int height)
		{
		}

		public void SetRect(int x, int y, int width, int height)
		{
		}

		public bool Intersects(Rectangle other)
		{
			return false;
		}

		public bool Contains(int x, int y)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
