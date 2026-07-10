using System;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	[Serializable]
	public class BadCrcException : ZipException
	{
		public BadCrcException()
		{
		}

		public BadCrcException(string message)
		{
		}

		protected BadCrcException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
