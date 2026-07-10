namespace Ionic.Zip.Deflate64
{
	internal sealed class OutputWindow
	{
		private const int WindowSize = 262144;

		private const int WindowMask = 262143;

		private readonly byte[] _window;

		private int _end;

		private int _bytesUsed;

		public int FreeBytes => 0;

		public int AvailableBytes => 0;

		internal void ClearBytesUsed()
		{
		}

		public void Write(byte b)
		{
		}

		public void WriteLengthDistance(int length, int distance)
		{
		}

		public int CopyFrom(InputBuffer input, int length)
		{
			return 0;
		}

		public int CopyTo(byte[] output, int offset, int length)
		{
			return 0;
		}
	}
}
