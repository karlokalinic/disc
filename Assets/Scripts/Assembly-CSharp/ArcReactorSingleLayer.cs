using System;
using UnityEngine;

[Serializable]
public class ArcReactorSingleLayer
{
	[SerializeField]
	private int m_LayerIndex;

	public int LayerIndex => 0;

	public int Mask => 0;

	public void Set(int _layerIndex)
	{
	}
}
