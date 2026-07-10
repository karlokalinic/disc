using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	public class MapManager : MonoBehaviour, ISerializableManager
	{
		private List<GameObject> mapGameObjects;

		[HideInInspector]
		public AbstractScheduleManager[] scheduleManagers;

		public string CurrentMapIdentifier { get; private set; }

		public CollageLocation CurrentLocation { get; private set; }

		public string SerializedCategoryName => null;

		public void LoadMap(CollageLocation locationToLoad, Vector3 elementsPositionOffset)
		{
		}

		private IEnumerator LoadMapCoroutine(CollageLocation locationToLoad, Vector3 elementsPositionOffset)
		{
			return null;
		}

		private void LoadSceneAsset(CollageLocation.Map newMap)
		{
		}

		public void UnloadCurrentMap()
		{
		}

		public void AddHiddenImage(CollageLocation.HiddenImages hiddenImagesData)
		{
		}

		public SerializableData Save()
		{
			return null;
		}

		public void Load(SerializableData data)
		{
		}

		private void TransferEntities(Vector3 offset)
		{
		}
	}
}
