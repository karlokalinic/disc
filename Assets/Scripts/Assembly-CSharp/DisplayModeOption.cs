using UnityEngine;

public class DisplayModeOption : OptionDropbox
{
	public static DisplayModeOption Instance;

	public override void Awake()
	{
	}

	public override void OnChange()
	{
	}

	public FullScreenMode GetFullScreenMode()
	{
		return default(FullScreenMode);
	}

	public override void ResetSettings()
	{
	}
}
