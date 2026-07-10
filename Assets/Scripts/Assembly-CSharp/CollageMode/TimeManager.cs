using UnityEngine;

namespace CollageMode
{
	public class TimeManager : MonoBehaviour, ISerializableManager
	{
		public string CurrentIdentifier { get; private set; }

		public string SerializedCategoryName => null;

		public void SetTime(int hour)
		{
		}

		public static string GetIdentifierFromData(int hour)
		{
			return null;
		}

		public SerializableData Save()
		{
			return null;
		}

		public void Load(SerializableData data)
		{
		}
	}
}
