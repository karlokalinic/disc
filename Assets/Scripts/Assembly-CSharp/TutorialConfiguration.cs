using UnityEngine.UI;

public class TutorialConfiguration : LiteSingleton<TutorialConfiguration>
{
	private string settingName;

	private bool valueBeforePreview;

	public Toggle toggle;

	public bool Value
	{
		get
		{
			return false;
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

	private void OnDestroy()
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

	public void OnValueChanged(bool value)
	{
	}
}
