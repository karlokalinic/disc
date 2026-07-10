using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
	private static ColorPicker currentPicker;

	[SerializeField]
	private Material colorChangeMat;

	[SerializeField]
	private string colPropertyName;

	[SerializeField]
	private RawImage colorDisplay;

	[SerializeField]
	private Button togglePickerButton;

	[SerializeField]
	private RectTransform pickerSlidersArea;

	[SerializeField]
	private Slider rSlider;

	[SerializeField]
	private Slider gSlider;

	[SerializeField]
	private Slider bSlider;

	private Color initCol;

	private Color currCol;

	private bool isShown;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void TogglePicker()
	{
	}

	private void ShowPicker()
	{
	}

	private void HidePicker()
	{
	}

	private void InitSlider(Slider slider)
	{
	}

	private void OnRChanged(float value)
	{
	}

	private void OnGChanged(float value)
	{
	}

	private void OnBChanged(float value)
	{
	}
}
