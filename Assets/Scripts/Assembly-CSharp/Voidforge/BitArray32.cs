using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public struct BitArray32
	{
		[SerializeField]
		private uint bits;

		[SerializeField]
		public readonly int length;

		public bool Item
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool All => false;

		public bool Any => false;

		public bool None => false;

		public BitArray32(int length = 32, bool value = false)
		{
			bits = 0u;
			this.length = 0;
		}

		public BitArray32(int length, uint value)
		{
			bits = 0u;
			this.length = 0;
		}

		public bool Equals(BitArray32 o)
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

		public static BitArray32 operator &(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}

		public static BitArray32 operator |(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}
	}
}
