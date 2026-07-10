using UnityEngine;
using UnityEngine.UI;

public class SliderFixedSteps : MonoBehaviour
{
	[SerializeField]
	private int steps;

	private Slider slider;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSliderValueChanged(float newValue)
	{
	}
}
