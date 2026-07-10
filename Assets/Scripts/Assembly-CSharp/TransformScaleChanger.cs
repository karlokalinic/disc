using UnityEngine;

public class TransformScaleChanger : MonoBehaviour
{
	[SerializeField]
	private bool keepMediumAndSmallTheSame;

	[SerializeField]
	private float changeMultiplier;

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
