using System;
using System.IO;

namespace Ionic.Zip.Deflate64
{
	internal sealed class Deflate64Stream : Stream
	{
		internal const int DefaultBufferSize = 8192;

		private Stream _stream;

		private InflaterManaged _inflater;

		private readonly byte[] _buffer;

		public override bool CanRead => false;

		public override bool CanWrite => false;

		public override bool CanSeek => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal Deflate64Stream(Stream stream, long uncompressedSize = -1L)
		{
		}

		public override void Flush()
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		private void ValidateParameters(byte[] array, int offset, int count)
		{
		}

		private void EnsureNotDisposed()
		{
		}

		private static void ThrowStreamClosedException()
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override void Write(byte[] array, int offset, int count)
		{
		}

		private void PurgeBuffers(bool disposing)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
