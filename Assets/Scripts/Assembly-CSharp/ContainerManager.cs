using System.Collections.Generic;
using UnityEngine;

public class ContainerManager : MonoBehaviour
{
	public List<ContainerArea> containerAreas;

	public float percentToBeSpawned;

	public static ContainerManager Current { get; private set; }

	private void Start()
	{
	}

	public void ContainerToggler()
	{
	}

	private void FindContainersFromHierarchy()
	{
	}

	private void OnEnable()
	{
	}

	public void RollItemsInContainers()
	{
	}
}
