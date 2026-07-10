using UnityEngine;

public class FakeMoneyFlipClock : LongNumericFlipClock
{
	[SerializeField]
	private AnimationCurve step;

	protected override string RetrieveStringForValue(long value)
	{
		return null;
	}

	protected override long CalculateMaxStep(long delta)
	{
		return 0L;
	}
}
