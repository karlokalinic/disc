using UnityEngine;

public class PoolObject : MonoBehaviour
{
	public GameObject originalPrefab { get; set; }

	public ObjectPool myPool { get; set; }

	private void OnDestroy()
	{
	}
}
