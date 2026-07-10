using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct OptionalUInt32
	{
		[SerializeField]
		private bool hasValue;

		[SerializeField]
		private uint value;

		public bool HasValue => false;

		public bool HasNoValue => false;

		public uint Value
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public OptionalUInt32(uint value)
		{
			hasValue = false;
			this.value = 0u;
		}

		public void Clear()
		{
		}

		public uint GetValueOrDefault(uint defaultValue)
		{
			return 0u;
		}

		public uint GetValueOrZero()
		{
			return 0u;
		}

		public void SetValue(uint value)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(OptionalUInt32 other)
		{
			return false;
		}

		public bool Equals(uint other)
		{
			return false;
		}

		public static bool operator ==(OptionalUInt32 a, OptionalUInt32 b)
		{
			return false;
		}

		public static bool operator !=(OptionalUInt32 a, OptionalUInt32 b)
		{
			return false;
		}

		public static bool operator ==(OptionalUInt32 a, uint b)
		{
			return false;
		}

		public static bool operator !=(OptionalUInt32 a, uint b)
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

		public static implicit operator OptionalUInt32(uint value)
		{
			return default(OptionalUInt32);
		}

		public static explicit operator uint(OptionalUInt32 optional)
		{
			return 0u;
		}
	}
}
