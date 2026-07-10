using System;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	[Serializable]
	public class BadReadException : ZipException
	{
		public BadReadException()
		{
		}

		public BadReadException(string message)
		{
		}

		public BadReadException(string message, Exception innerException)
		{
		}

		protected BadReadException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
