public class VoiceOverModeOption : OptionDropbox
{
	public enum VOMode
	{
		Full = 0,
		Psychological = 1,
		Classic = 2
	}

	protected override SETTINGS_CATEGORY settingsCategory => default(SETTINGS_CATEGORY);

	public override void OnChange()
	{
	}

	public override void ReApply()
	{
	}

	public override void ResetSettings()
	{
	}

	public VOMode GetVoiceOverMode()
	{
		return default(VOMode);
	}
}
