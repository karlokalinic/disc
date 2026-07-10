using System;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	[Serializable]
	public class BadPasswordException : ZipException
	{
		public BadPasswordException()
		{
		}

		public BadPasswordException(string message)
		{
		}

		public BadPasswordException(string message, Exception innerException)
		{
		}

		protected BadPasswordException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
