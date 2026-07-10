using UnityEngine;
using UnityEngine.UI;

public class ScrollRectSlider : MonoBehaviour
{
	[SerializeField]
	private Slider slider;

	[SerializeField]
	private bool useXAxis;

	private ScrollRect scrollRect;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSliderValueChanged(float value)
	{
	}

	private void OnScrollRectValueChanged(Vector2 value)
	{
	}
}
