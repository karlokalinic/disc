using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

public class SliderButtonHandler : MonoBehaviour
{
	[SerializeField]
	private Button buttonIncrease;

	[SerializeField]
	private Button buttonDecrease;

	[SerializeField]
	private float step;

	private Slider slider;

	private OptionsView optionsView;

	public bool InputActive { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnIncreaseClicked()
	{
	}

	private void OnDecreaseClicked()
	{
	}

	private bool CheckIfCurrentSliderIsSelected()
	{
		return false;
	}
}
