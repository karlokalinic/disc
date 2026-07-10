using System.Collections.Generic;
using UnityEngine;

public class ArcReactor_PoolManager : MonoBehaviour
{
	public Transform poolParent;

	public Dictionary<GameObject, List<ArcReactor_Arc>> freeEntities;

	public Dictionary<ArcReactor_Arc, GameObject> activeEntities;

	public static ArcReactor_PoolManager Instance { get; private set; }

	protected void Awake()
	{
	}

	public GameObject GetFreeEntity(GameObject originalPrefab)
	{
		return null;
	}

	public void SetEntityAsFree(ArcReactor_Arc arc)
	{
	}
}
