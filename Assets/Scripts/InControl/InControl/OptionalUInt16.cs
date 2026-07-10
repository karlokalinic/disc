using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct OptionalUInt16
	{
		[SerializeField]
		private bool hasValue;

		[SerializeField]
		private ushort value;

		public bool HasValue => false;

		public bool HasNoValue => false;

		public ushort Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public OptionalUInt16(ushort value)
		{
			hasValue = false;
			this.value = 0;
		}

		public void Clear()
		{
		}

		public ushort GetValueOrDefault(ushort defaultValue)
		{
			return 0;
		}

		public ushort GetValueOrZero()
		{
			return 0;
		}

		public void SetValue(ushort value)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(OptionalUInt16 other)
		{
			return false;
		}

		public bool Equals(ushort other)
		{
			return false;
		}

		public static bool operator ==(OptionalUInt16 a, OptionalUInt16 b)
		{
			return false;
		}

		public static bool operator !=(OptionalUInt16 a, OptionalUInt16 b)
		{
			return false;
		}

		public static bool operator ==(OptionalUInt16 a, ushort b)
		{
			return false;
		}

		public static bool operator !=(OptionalUInt16 a, ushort b)
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

		public static implicit operator OptionalUInt16(ushort value)
		{
			return default(OptionalUInt16);
		}

		public static explicit operator ushort(OptionalUInt16 optional)
		{
			return 0;
		}
	}
}
