using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class Frame : MonoBehaviour, ISerializableManager
	{
		[SerializeField]
		private Image frameImage;

		public string CurrentFrameIdentifier { get; private set; }

		public string SerializedCategoryName => null;

		public void SetFrame(string frameIdentifier)
		{
		}

		public void SetPreview(bool isPreview)
		{
		}

		public void Clear()
		{
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
