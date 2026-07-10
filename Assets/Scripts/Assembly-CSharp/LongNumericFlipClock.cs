using UnityEngine;

public class LongNumericFlipClock : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve flipSpeed;

	[SerializeField]
	private float defaultSpeed;

	private FlipClock flipClock;

	private long currentValue;

	private long targetValue;

	private bool skipIntermediateValues;

	private long NextValue => 0L;

	private long Min(long a, long b)
	{
		return 0L;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Clear()
	{
	}

	public void SetValue(long targetValue, bool skipIntermediateValues = false)
	{
	}

	private void OnFlipAnimationFinished()
	{
	}

	private float CalculateAnimationSpeedMultiplier()
	{
		return 0f;
	}

	protected virtual string RetrieveStringForValue(long value)
	{
		return null;
	}

	protected virtual long CalculateMaxStep(long delta)
	{
		return 0L;
	}

	protected virtual void OnLanguageChanged()
	{
	}
}
