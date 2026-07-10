using UnityEngine;
using UnityEngine.UI;

public class LayoutElementSizeChanger : MonoBehaviour
{
	[SerializeField]
	private bool keepMediumAndSmallTheSame;

	private LayoutElement layoutElement;

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
