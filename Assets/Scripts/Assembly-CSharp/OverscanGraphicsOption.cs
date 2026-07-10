using UnityEngine;
using UnityEngine.UI;

public class OverscanGraphicsOption : LiteSingleton<OverscanGraphicsOption>
{
	protected string settingName;

	private Slider slider;

	private float valueBeforePreview;

	private GameObject globalUIFitter;

	public static Image overscanBordersInstance;

	public float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	private void OnOverscanChanged(float arg1, float arg2)
	{
	}

	private void OnDestroy()
	{
	}

	public void OnEnable()
	{
	}

	public void OnChange()
	{
	}

	public void PreviewReset()
	{
	}

	public void CancelPreview()
	{
	}

	public void ResetSettings()
	{
	}

	private void Update()
	{
	}

	private bool CheckIfCurrentSliderIsSelected()
	{
		return false;
	}
}
