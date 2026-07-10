using UnityEngine;

public class SegmentIndicatorTest : MonoBehaviour
{
	private SegmentIndicator segmentIndicator;

	[SerializeField]
	public int current;

	[SerializeField]
	public int max;

	[SerializeField]
	public int predictValue;

	[SerializeField]
	public bool predictHeal;

	[SerializeField]
	public bool predictDamage;

	[SerializeField]
	public bool hidePrediction;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
