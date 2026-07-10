using UnityEngine;

public class MoneyFlipClock : NumericFlipClock
{
	[SerializeField]
	private AnimationCurve step;

	protected override string RetrieveStringForValue(int value)
	{
		return null;
	}

	protected override int CalculateMaxStep(int delta)
	{
		return 0;
	}
}
