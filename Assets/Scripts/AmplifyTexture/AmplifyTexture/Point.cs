using System;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class Point
	{
		public int x;

		public int y;

		public static Point zero;

		public static Point Zero => null;

		public int Item
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Point()
		{
		}

		public Point(int x, int y)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static Point operator +(Point point1, Point point2)
		{
			return null;
		}
	}
}
