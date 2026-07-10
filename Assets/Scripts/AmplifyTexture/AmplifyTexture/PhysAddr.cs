using System.Runtime.InteropServices;

namespace AmplifyTexture
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 2)]
	public struct PhysAddr
	{
		public ushort physicalAddress;

		public int x => 0;

		public int y => 0;

		public int mip => 0;

		public static ushort Pack(int x, int y, int mip)
		{
			return 0;
		}

		public PhysAddr(ushort addr)
		{
			physicalAddress = 0;
		}

		public void Set(int x, int y, int mip)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
