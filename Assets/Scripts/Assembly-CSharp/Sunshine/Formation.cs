using System;
using UnityEngine;

namespace Sunshine
{
	[Serializable]
	public struct Formation
	{
		public enum Purpose
		{
			UNIVERSAL = 0,
			INTERACTION = 1,
			ARRIVAL = 2
		}

		public enum Type
		{
			CUSTOM = 0,
			DOUBLE_COLUMN = 1,
			COLUMN = 2,
			LINE = 3,
			CHESSBOARD = 4,
			ARROWHEAD = 5,
			BOX = 6,
			INVALID = 999
		}

		[Serializable]
		public struct Location
		{
			[SerializeField]
			private float _h;

			[SerializeField]
			private float _x;

			[SerializeField]
			private float _y;

			[SerializeField]
			private float _z;

			public static Location zero;

			public float heading
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

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

			public float x
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float y
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float z
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public Location(Vector3 pos, float heading = 0f)
			{
				_h = 0f;
				_x = 0f;
				_y = 0f;
				_z = 0f;
			}

			public Location(float x, float y, float z, float heading = 0f)
			{
				_h = 0f;
				_x = 0f;
				_y = 0f;
				_z = 0f;
			}

			public static explicit operator Vector3(Location location)
			{
				return default(Vector3);
			}

			public static explicit operator float(Location location)
			{
				return 0f;
			}
		}

		[SerializeField]
		private Type _type;

		[SerializeField]
		private Location[] _locations;

		private static ArrayPool<Location> locationsPool;

		public static Formation Invalid;

		public bool IsValid => false;

		public Location Item => default(Location);

		public int Count => 0;

		public Type type
		{
			get
			{
				return default(Type);
			}
			private set
			{
			}
		}

		public Formation(Formation source, bool usePool = false)
		{
			_type = default(Type);
			_locations = null;
		}

		public Formation(Formation source, int minSize, bool usePool = false)
		{
			_type = default(Type);
			_locations = null;
		}

		public Formation(int minSize, bool usePool = false)
		{
			_type = default(Type);
			_locations = null;
		}

		public void Release()
		{
		}

		public Formation Clone()
		{
			return default(Formation);
		}

		public float GetHeading(int index)
		{
			return 0f;
		}

		public Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		public Vector3 GetAveragePosition()
		{
			return default(Vector3);
		}

		public void SetHeading(int index, float value)
		{
		}

		public void SetPosition(int index, Vector3 value)
		{
		}

		public void SetPosition(int index, float x, float y, float z)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public Formation Translate(float angle, Vector3 distance)
		{
			return default(Formation);
		}

		public Formation Translate(Vector3 distance, float angle)
		{
			return default(Formation);
		}

		public void TranslateTo(float angle, Vector3 distance)
		{
		}

		public void TranslateTo(Vector3 distance, float angle)
		{
		}

		public static Formation CreateDynamic(int count, Sector sector, bool usePool = false)
		{
			return default(Formation);
		}

		public static Formation CreateDynamicPredefined(int count, Sector sector, bool usePool = false)
		{
			return default(Formation);
		}

		public static Formation Create(Type type, int count, bool usePool = false)
		{
			return default(Formation);
		}

		public static bool IsPossible(Type type, int count)
		{
			return false;
		}

		public static Formation Parse(string value)
		{
			return default(Formation);
		}

		private void Initialize(int size, bool usePool)
		{
		}

		private void Initialize(Formation source, int size, bool usePool)
		{
		}
	}
}
