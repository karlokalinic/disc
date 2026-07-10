using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PixelCrushers
{
	public class BinaryDataSerializer : DataSerializer
	{
		protected virtual void AddSurrogateSelectors(SurrogateSelector surrogateSelector)
		{
		}

		protected virtual BinaryFormatter CreateBinaryFormatter()
		{
			return null;
		}

		public override string Serialize(object data)
		{
			return null;
		}

		public override T Deserialize<T>(string s, T data = default(T))
		{
			return default(T);
		}
	}
}
