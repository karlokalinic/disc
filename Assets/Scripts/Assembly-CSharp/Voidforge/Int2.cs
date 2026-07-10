using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public struct Int2
	{
		public int x;

		public int y;

		public int Magnitude => 0;

		public static Int2 one => default(Int2);

		public static Int2 zero => default(Int2);

		public Int2(int x, int y)
		{
			this.x = 0;
			this.y = 0;
		}

		public Int2(float x, float y)
		{
			this.x = 0;
			this.y = 0;
		}

		public Int2(Vector2 v)
		{
			x = 0;
			y = 0;
		}

		public bool Equals(Int2 o)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static Int2 operator +(Int2 a, Int2 b)
		{
			return default(Int2);
		}

		public static Int2 operator -(Int2 a, Int2 b)
		{
			return default(Int2);
		}

		public static Int2 Max(Int2 a, Int2 b)
		{
			return default(Int2);
		}

		public static Int2 Max(Int2 a, Int2 b, Int2 c)
		{
			return default(Int2);
		}

		public static Int2 Min(Int2 a, Int2 b)
		{
			return default(Int2);
		}

		public static Int2 Min(Int2 a, Int2 b, Int2 c)
		{
			return default(Int2);
		}
	}
}
