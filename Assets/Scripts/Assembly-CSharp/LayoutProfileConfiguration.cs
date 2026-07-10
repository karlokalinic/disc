using UnityEngine.UI;

public class LayoutProfileConfiguration : LiteSingleton<LayoutProfileConfiguration>
{
	public const string BASE_LAYOUT_PROFILE_TAG = "layoutProfile";

	public const string HANDHELD_LAYOUT_PROFILE_POSTFIX = "Handheld";

	private int valueBeforePreview;

	public Slider slider;

	public static int DefaultProfile => 0;

	public static bool IsCurrentlyInHandheld => false;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSwitchChangedOperationMode(NXapiControl.OperationMode obj)
	{
	}

	public static string GetCurrentProfileLayoutSettingsTag(bool isHandheld)
	{
		return null;
	}

	private void OnSliderValueChanged(float value)
	{
	}

	public void ReApply()
	{
	}

	public void ResetSettings()
	{
	}

	public void PreviewReset()
	{
	}

	public void CancelPreview()
	{
	}

	public static int GetCurrentLayoutProfile(bool isHandheld)
	{
		return 0;
	}

	private static void StoreChangedLayoutOptionValue(bool isHandheld, int selectedProfile)
	{
	}
}
