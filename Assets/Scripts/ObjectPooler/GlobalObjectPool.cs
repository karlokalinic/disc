using System.Collections.Generic;
using UnityEngine;

public class GlobalObjectPool
{
	private static GlobalObjectPool _singleton;

	private Dictionary<GameObject, ObjectPool> _pools;

	private static GlobalObjectPool Singleton => null;

	public static void Clear()
	{
	}

	public static void CreatePool(GameObject prefab, int numberOfObjects, bool dontDestroyOnLoad = true)
	{
	}

	public static GameObject GetObject(GameObject prefab)
	{
		return null;
	}

	private static ObjectPool GetPoolForPrefab(GameObject prefab)
	{
		return null;
	}

	public static GameObject GetObject(GameObject prefab, Transform parent)
	{
		return null;
	}

	public static void ReturnToPool(GameObject prefab, GameObject poolObject)
	{
	}

	public static void ObjectWasDeleted()
	{
	}
}
