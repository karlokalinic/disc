using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct OptionalInt32
	{
		[SerializeField]
		private bool hasValue;

		[SerializeField]
		private int value;

		public bool HasValue => false;

		public bool HasNoValue => false;

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public OptionalInt32(int value)
		{
			hasValue = false;
			this.value = 0;
		}

		public void Clear()
		{
		}

		public int GetValueOrDefault(int defaultValue)
		{
			return 0;
		}

		public int GetValueOrZero()
		{
			return 0;
		}

		public void SetValue(int value)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(OptionalInt32 other)
		{
			return false;
		}

		public bool Equals(int other)
		{
			return false;
		}

		public static bool operator ==(OptionalInt32 a, OptionalInt32 b)
		{
			return false;
		}

		public static bool operator !=(OptionalInt32 a, OptionalInt32 b)
		{
			return false;
		}

		public static bool operator ==(OptionalInt32 a, int b)
		{
			return false;
		}

		public static bool operator !=(OptionalInt32 a, int b)
		{
			return false;
		}

		private static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator OptionalInt32(int value)
		{
			return default(OptionalInt32);
		}

		public static explicit operator int(OptionalInt32 optional)
		{
			return 0;
		}
	}
}
