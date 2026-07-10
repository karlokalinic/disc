using UnityEngine;

public class ColliderAreaStateSwitcher : MonoBehaviour
{
	[SerializeField]
	public string areaName;

	[SerializeField]
	public string stateName;

	public void Awake()
	{
	}

	public void OnTriggerEnter(Collider other)
	{
	}
}
