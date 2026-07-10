using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public struct Path
	{
		[Serializable]
		public struct Point
		{
			[SerializeField]
			private Vector3 _position;

			[SerializeField]
			private Vector4 _leftTangent;

			[SerializeField]
			private Vector4 _rightTangent;

			public Vector3 position
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Vector3 leftTangent
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Vector3 leftTangentDirection
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Vector3 rightTangent
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Vector3 rightTangentDirection
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Point(Vector3 point, Vector3 left, Vector3 right)
			{
				_position = default(Vector3);
				_leftTangent = default(Vector4);
				_rightTangent = default(Vector4);
			}

			public Point Transform(Transform transform, bool inverse)
			{
				return default(Point);
			}

			public static float Distance(Point a, Point b)
			{
				return 0f;
			}

			public static Point Lerp(Point a, Point b, float t)
			{
				return default(Point);
			}
		}

		[SerializeField]
		private bool _isLoop;

		[SerializeField]
		private Point[] _points;

		private float[] _distances;

		public Point this[int index]
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		public Point this[long index] => default(Point);

		public int Count => 0;

		public float magnitude => 0f;

		public bool isLoop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Path(int count)
		{
			_isLoop = false;
			_points = null;
			_distances = null;
		}

		public void Add(Point newPoint)
		{
		}

		public void Remove(int index)
		{
		}

		public void SubDiv(float t)
		{
		}

		public Path Transform(Transform transform, bool inverse)
		{
			return default(Path);
		}

		private void CalculateDistances()
		{
		}

		private Tuple<int, int, float> GetSegment(float t)
		{
			return null;
		}
	}
}
