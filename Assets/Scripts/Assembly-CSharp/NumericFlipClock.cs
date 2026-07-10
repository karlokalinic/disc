using UnityEngine;

public class NumericFlipClock : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve flipSpeed;

	private FlipClock flipClock;

	private int currentValue;

	private int targetValue;

	private bool skipIntermediateValues;

	private int NextValue => 0;

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

	public void SetValue(int targetValue, bool skipIntermediateValues = false)
	{
	}

	private void OnFlipAnimationFinished()
	{
	}

	private float CalculateAnimationSpeedMultiplier()
	{
		return 0f;
	}

	protected virtual string RetrieveStringForValue(int value)
	{
		return null;
	}

	protected virtual int CalculateMaxStep(int delta)
	{
		return 0;
	}

	protected virtual void OnLanguageChanged()
	{
	}
}
