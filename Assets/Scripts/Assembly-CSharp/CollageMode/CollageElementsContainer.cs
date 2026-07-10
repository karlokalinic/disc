using System;
using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	public class CollageElementsContainer : MonoBehaviour, ISerializableManager
	{
		public class CollageElementsSerialized : SerializableData
		{
			public List<CollageElement.InitData> elements;
		}

		[SerializeField]
		private Sticker stickerPrefab;

		[SerializeField]
		private CollageText textPrefab;

		[SerializeField]
		private Fragment fragmentPrefab;

		[SerializeField]
		private CollageCharacter collageCharacterPrefab;

		[SerializeField]
		private Transform cameraElementsParent;

		[SerializeField]
		private Transform worldElementsParent;

		private Dictionary<Guid, CollageElement> collageElements;

		public Transform CameraElementParent => null;

		public int CollageElementMaxSortingOrder { get; set; }

		public string SerializedCategoryName => null;

		private void Start()
		{
		}

		public void Clear()
		{
		}

		public void Remove(CollageElement collageElement)
		{
		}

		public CollageElement Get(Guid guid)
		{
			return null;
		}

		public T Get<T>(Guid guid) where T : CollageElement
		{
			return null;
		}

		public IEnumerable<CollageElement> GetAllElements()
		{
			return null;
		}

		public CollageElement Create(CollageElement.InitData initData)
		{
			return null;
		}

		private T Create<T>(T prefab, Transform parent, CollageElement.InitData initData) where T : CollageElement
		{
			return null;
		}

		private void OnSelectionChanged(CollageElement selected, SelectionMode selectionMode)
		{
		}

		private void PutCollageElementOnTop(CollageElement selected)
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
