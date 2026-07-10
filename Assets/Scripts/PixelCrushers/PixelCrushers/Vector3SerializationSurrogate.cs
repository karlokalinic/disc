using System.Runtime.Serialization;

namespace PixelCrushers
{
	public class Vector3SerializationSurrogate : ISerializationSurrogate
	{
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
		}

		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			return null;
		}
	}
}
