using System;

namespace AmplifyTexture
{
	public struct Page : IEquatable<Page>
	{
		public uint virtualAddress;

		public PhysAddr physicalAddress;

		public ushort requestCount;

		public ushort x
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ushort y
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public byte mip
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public byte asset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(Page other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
