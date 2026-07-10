using System;

public class OverscanUtils
{
	public const float OverscanMaxScreenPercentage = 0.063f;

	public const string SETTING_OVERSCAN = "OVERSCAN";

	public static float OverscanValue;

	private static float PrevOverscanValue;

	private static float Percentage;

	private static float Size;

	public static Action<float, float> OnOverscanChanged;

	public static void SetOverscanValue(float os)
	{
	}

	public static void ComputeOverscanPercentages()
	{
	}

	public static void TriggerOnOverscanChanged()
	{
	}
}
