public class KeyboardMappingOption : OptionDropbox
{
	public static KeyboardMappingOption Instance;

	private int currentLayoutIndex;

	public override void Awake()
	{
	}

	public override void OnChange()
	{
	}

	private KeyboardLayoutBindings.KeyboardLayout GetKeyboardLayoutFromValue()
	{
		return default(KeyboardLayoutBindings.KeyboardLayout);
	}

	public override void ResetSettings()
	{
	}
}
