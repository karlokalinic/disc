using UnityEngine;

namespace Voidforge
{
	public struct Line
	{
		public Ray ray;

		public float length;

		public Vector3 origin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 direction
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 target
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Line(Ray ray, float lineLength)
		{
			this.ray = default(Ray);
			length = 0f;
		}

		public Line(Vector3 lineOrigin, Vector3 lineDirection, float lineLength)
		{
			ray = default(Ray);
			length = 0f;
		}

		public Line(Vector3 lineOrigin, Vector3 lineTarget)
		{
			ray = default(Ray);
			length = 0f;
		}

		public Line(Vector3 lineOrigin, Ray tangent)
		{
			ray = default(Ray);
			length = 0f;
		}

		public Line(Vector3 screenPoint, Camera camera)
		{
			ray = default(Ray);
			length = 0f;
		}

		public static Line operator +(Line line, Vector3 offset)
		{
			return default(Line);
		}

		public static Line operator *(Line line, float scale)
		{
			return default(Line);
		}

		public static Line operator *(float scale, Line line)
		{
			return default(Line);
		}

		public static Line operator *(Quaternion rotation, Line line)
		{
			return default(Line);
		}
	}
}
