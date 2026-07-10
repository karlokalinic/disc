public class HighlightToggleConfiguration : OptionsCheckboxConfiguration<HighlightToggleConfiguration>
{
	protected override string SettingName => null;

	protected override bool DefaultValue => false;

	private void Start()
	{
	}

	public override void OnValueChanged(bool value)
	{
	}
}
