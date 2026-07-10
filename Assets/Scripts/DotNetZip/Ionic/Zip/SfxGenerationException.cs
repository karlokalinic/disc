using System;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	[Serializable]
	public class SfxGenerationException : ZipException
	{
		public SfxGenerationException()
		{
		}

		public SfxGenerationException(string message)
		{
		}

		protected SfxGenerationException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
