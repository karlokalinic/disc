using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public class SpawnedObjectManager : Saver
	{
		[Serializable]
		public class SpawnedObjectData
		{
			public string prefabName;

			public Vector3 position;

			public Quaternion rotation;

			public SpawnedObjectData()
			{
			}

			public SpawnedObjectData(string prefabName, Vector3 position, Quaternion rotation)
			{
			}
		}

		[Serializable]
		public class SpawnedObjectDataList
		{
			public List<SpawnedObjectData> list;
		}

		[SerializeField]
		private List<SpawnedObject> m_spawnedObjectPrefabs;

		[SerializeField]
		private List<SpawnedObject> m_spawnedObjects;

		private static SpawnedObjectManager m_instance;

		public List<SpawnedObject> spawnedObjectPrefabs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SpawnedObject> spawnedObjects
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string data)
		{
		}

		protected SpawnedObject GetSpawnedObjectPrefab(string prefabName)
		{
			return null;
		}

		public static void AddSpawnedObjectData(SpawnedObject spawnedObject)
		{
		}

		public static void RemoveSpawnedObjectData(SpawnedObject spawnedObject)
		{
		}
	}
}
