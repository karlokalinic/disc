namespace Ionic.Zip.Deflate64
{
	internal sealed class HuffmanTree
	{
		internal const int MaxLiteralTreeElements = 288;

		internal const int MaxDistTreeElements = 32;

		internal const int EndOfBlockCode = 256;

		internal const int NumberOfCodeLengthTreeElements = 19;

		private readonly int _tableBits;

		private readonly short[] _table;

		private readonly short[] _left;

		private readonly short[] _right;

		private readonly byte[] _codeLengthArray;

		private readonly int _tableMask;

		public static HuffmanTree StaticLiteralLengthTree { get; }

		public static HuffmanTree StaticDistanceTree { get; }

		public HuffmanTree(byte[] codeLengths)
		{
		}

		private static byte[] GetStaticLiteralTreeLength()
		{
			return null;
		}

		private static byte[] GetStaticDistanceTreeLength()
		{
			return null;
		}

		private static uint BitReverse(uint code, int length)
		{
			return 0u;
		}

		private uint[] CalculateHuffmanCode()
		{
			return null;
		}

		private void CreateTable()
		{
		}

		public int GetNextSymbol(InputBuffer input)
		{
			return 0;
		}
	}
}
