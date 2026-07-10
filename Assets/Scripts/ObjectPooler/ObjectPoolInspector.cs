using System;
using UnityEngine;

[Serializable]
public class ObjectPoolInspector
{
	public string Name;

	public int NumeberOfObjects;

	[SerializeField]
	private GameObject _prefab;

	private static Transform _scenePoolParent;

	public ObjectPool GetObjectPool { get; private set; }

	public void Initiate()
	{
	}
}
