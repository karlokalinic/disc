using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ObjectPool
{
	private static Transform m_megaParent;

	[SerializeField]
	private Stack<GameObject> m_available_objects;

	[SerializeField]
	private List<GameObject> m_used_objects;

	[SerializeField]
	private GameObject m_prefab;

	[SerializeField]
	private Transform m_parent;

	[SerializeField]
	private bool m_canBeIncreased;

	public bool isPopulated;

	private int initNumOfObjects;

	public ObjectPool(GameObject _prefab, int _numberOfObject, bool _canIncrease = false, bool _populateImmidietly = true, Transform _parentForPool = null, bool dontDestroyOnLoad = false)
	{
	}

	public void Populate()
	{
	}

	public void Clear()
	{
	}

	private GameObject SpawnNewPoolObject(int _id = 0, bool setAsFirstSibling = false)
	{
		return null;
	}

	public void ReturnObjectToPool(GameObject _go)
	{
	}

	public IEnumerator ReturnObjectToPool(GameObject _ob, float _disableDelay)
	{
		return null;
	}

	private GameObject GetObjectFromPool()
	{
		return null;
	}

	private GameObject PrepareObject(GameObject gameObject)
	{
		return null;
	}

	public GameObject GetObject(Vector3 _position, Quaternion _rotation)
	{
		return null;
	}

	public GameObject GetObject(Vector3 position)
	{
		return null;
	}

	public GameObject GetObject()
	{
		return null;
	}

	public void ReturnAllObjects()
	{
	}
}
