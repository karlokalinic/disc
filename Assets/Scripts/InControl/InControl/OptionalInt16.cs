using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct OptionalInt16
	{
		[SerializeField]
		private bool hasValue;

		[SerializeField]
		private short value;

		public bool HasValue => false;

		public bool HasNoValue => false;

		public short Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public OptionalInt16(short value)
		{
			hasValue = false;
			this.value = 0;
		}

		public void Clear()
		{
		}

		public short GetValueOrDefault(short defaultValue)
		{
			return 0;
		}

		public short GetValueOrZero()
		{
			return 0;
		}

		public void SetValue(short value)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(OptionalInt16 other)
		{
			return false;
		}

		public bool Equals(short other)
		{
			return false;
		}

		public static bool operator ==(OptionalInt16 a, OptionalInt16 b)
		{
			return false;
		}

		public static bool operator !=(OptionalInt16 a, OptionalInt16 b)
		{
			return false;
		}

		public static bool operator ==(OptionalInt16 a, short b)
		{
			return false;
		}

		public static bool operator !=(OptionalInt16 a, short b)
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

		public static implicit operator OptionalInt16(short value)
		{
			return default(OptionalInt16);
		}

		public static explicit operator short(OptionalInt16 optional)
		{
			return 0;
		}
	}
}
