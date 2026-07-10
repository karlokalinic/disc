using System.Runtime.Serialization;

namespace PixelCrushers
{
	public class QuaternionSerializationSurrogate : ISerializationSurrogate
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
