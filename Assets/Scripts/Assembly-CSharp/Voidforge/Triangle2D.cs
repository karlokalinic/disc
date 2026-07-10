using UnityEngine;

namespace Voidforge
{
	public struct Triangle2D
	{
		public readonly Vector2 p0;

		public readonly Vector2 p1;

		public readonly Vector2 p2;

		private Vector2 e0;

		private Vector2 e1;

		private float detR;

		public Triangle2D(Vector2 a, Vector2 b, Vector2 c)
		{
			p0 = default(Vector2);
			p1 = default(Vector2);
			p2 = default(Vector2);
			e0 = default(Vector2);
			e1 = default(Vector2);
			detR = 0f;
		}

		public Vector3 Bary(Vector2 p)
		{
			return default(Vector3);
		}

		public Vector2 Point(Vector3 bary)
		{
			return default(Vector2);
		}
	}
}
