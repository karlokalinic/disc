using System.Runtime.InteropServices;

namespace AmplifyTexture
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 16)]
	public struct AssetDesc
	{
		public uint assetIndex;

		public uint maxTopSize;

		public uint maxMip;

		public uint mipCount;
	}
}
