using System;
using System.Runtime.Serialization;

namespace UnityEngine.AddressableAssets
{
	public class InvalidKeyException : Exception
	{
		public object Key { get; private set; }

		public Type Type { get; private set; }

		public override string Message => null;

		public InvalidKeyException(object key)
		{
		}

		public InvalidKeyException(object key, Type type)
		{
		}

		public InvalidKeyException()
		{
		}

		public InvalidKeyException(string message)
		{
		}

		public InvalidKeyException(string message, Exception innerException)
		{
		}

		protected InvalidKeyException(SerializationInfo message, StreamingContext context)
		{
		}
	}
}
