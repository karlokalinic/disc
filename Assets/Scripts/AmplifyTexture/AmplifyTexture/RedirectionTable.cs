using System.IO;

namespace AmplifyTexture
{
	public class RedirectionTable
	{
		public const long Invalid = 281474976710655L;

		public const int ElementSizeInBytes = 6;

		private const int BufferSize = 524288;

		private uint[] m_part0;

		private ushort[] m_part1;

		public long Item
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public RedirectionTable(int size)
		{
		}

		~RedirectionTable()
		{
		}

		public void Import(BinaryReader reader)
		{
		}

		public void Export(BinaryWriter writer)
		{
		}

		private void ReadArray<T>(BinaryReader reader, ref T[] array)
		{
		}

		private void WriteArray<T>(BinaryWriter writer, ref T[] array)
		{
		}
	}
}
