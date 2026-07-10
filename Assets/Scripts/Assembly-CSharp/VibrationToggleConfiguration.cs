public class VibrationToggleConfiguration : OptionsCheckboxConfiguration<VibrationToggleConfiguration>
{
	protected override string SettingName => null;

	protected override bool DefaultValue => false;

	public override void OnValueChanged(bool value)
	{
	}
}
