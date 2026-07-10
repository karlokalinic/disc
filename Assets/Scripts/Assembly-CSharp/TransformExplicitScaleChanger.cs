using System.Collections.Generic;
using UnityEngine;

public class TransformExplicitScaleChanger : MonoBehaviour
{
	[SerializeField]
	private List<float> scales;

	private Vector3 defaultScale;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnTextSizeChanged(TextSizeConfiguration.TextSize textSize)
	{
	}
}
