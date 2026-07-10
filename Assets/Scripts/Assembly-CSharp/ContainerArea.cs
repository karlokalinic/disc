using System;
using Sunshine;
using UnityEngine;

[Serializable]
public class ContainerArea
{
	public string name;

	public GameObject containerParent;

	private ContainerSource[] _containers;

	public int containerLimit;

	public ContainerSource[] Containers => null;
}
