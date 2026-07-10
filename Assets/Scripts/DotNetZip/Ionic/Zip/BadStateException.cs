using System;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	[Serializable]
	public class BadStateException : ZipException
	{
		public BadStateException()
		{
		}

		public BadStateException(string message)
		{
		}

		public BadStateException(string message, Exception innerException)
		{
		}

		protected BadStateException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
