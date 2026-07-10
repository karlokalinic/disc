using System;

public class ShaderGraphicsOption : OptionDropbox
{
	public delegate void OnChanged(int value);

	public static Action<int> OnChangedCall;

	private static int forcedDownsample;

	private new void Awake()
	{
	}

	public override void OnChange()
	{
	}
}
