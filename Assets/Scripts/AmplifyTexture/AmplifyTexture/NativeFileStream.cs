using System.IO;

namespace AmplifyTexture
{
	public class NativeFileStream : Stream
	{
		private static readonly bool DebugEnabled;

		private string m_path;

		private FileStream m_fileStream;

		public string Path => null;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

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

		public NativeFileStream(string path, FileMode fileMode, FileAccess fileAccess, FileShare fileShare)
		{
		}

		public NativeFileStream(string path, FileMode fileMode, FileAccess fileAccess, FileShare fileShare, int bufferSize, bool useAsync)
		{
		}

		public bool IsCreated()
		{
			return false;
		}

		public override void Close()
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
