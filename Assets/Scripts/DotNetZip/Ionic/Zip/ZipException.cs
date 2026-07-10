using System;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	[Serializable]
	public class ZipException : Exception
	{
		public ZipException()
		{
		}

		public ZipException(string message)
		{
		}

		public ZipException(string message, Exception innerException)
		{
		}

		protected ZipException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
