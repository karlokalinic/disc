using UnityEngine;

namespace PixelCrushers
{
	public class JsonDataSerializer : DataSerializer
	{
		[SerializeField]
		private bool m_prettyPrint;

		public bool prettyPrint
		{
			get
			{
				return false;
			}
			set
			{
			}
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
