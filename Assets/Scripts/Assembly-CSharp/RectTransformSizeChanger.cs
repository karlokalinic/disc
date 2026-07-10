using UnityEngine;

public class RectTransformSizeChanger : MonoBehaviour
{
	[SerializeField]
	private bool keepMediumAndSmallTheSame;

	[SerializeField]
	private bool updateWidth;

	[SerializeField]
	private bool updateHeight;

	[SerializeField]
	private float changeMultiplier;

	private RectTransform rectTransform;

	private float defaultHeight;

	private float defaultWidth;

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
