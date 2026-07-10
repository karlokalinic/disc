using UnityEngine.UI;

public class GammaGraphicsOption : LiteSingleton<GammaGraphicsOption>
{
	protected string settingName;

	private Slider slider;

	private float valueBeforePreview;

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

	public void OnEnable()
	{
	}

	public void ReApply()
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
}
