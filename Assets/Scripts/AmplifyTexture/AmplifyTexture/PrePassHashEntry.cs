using System.Runtime.InteropServices;

namespace AmplifyTexture
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 8)]
	public struct PrePassHashEntry
	{
		public uint key;

		public ushort count;

		public ushort next;
	}
}
