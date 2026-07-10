using UnityEngine;

namespace CollageMode
{
	public class WeatherManager : MonoBehaviour, ISerializableManager
	{
		private const float TRANSITION_TIME = 0.3f;

		public string SerializedCategoryName => null;

		private void Start()
		{
		}

		public void SetWeather(string newWeather)
		{
		}

		public void Load(SerializableData data)
		{
		}

		public SerializableData Save()
		{
			return null;
		}
	}
}
