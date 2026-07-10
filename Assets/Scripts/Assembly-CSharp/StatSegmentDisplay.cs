using Sunshine;
using Sunshine.Metric;
using UnityEngine;

public class StatSegmentDisplay : MonoBehaviour
{
	private const int RANK = 0;

	private const int DOWNGRADEABLE = 1;

	private const int UPGRADEABLE = 2;

	private const int EMPTY = 3;

	public CharacterSheet character;

	public AbilityType ability;

	private BaseSegmentIndicator indicator;

	private TooltipSource tooltipSource;

	protected void Start()
	{
	}

	public void InitData()
	{
	}

	public void UpdateData()
	{
	}

	public void UpdateForDisplay()
	{
	}

	public void UpdateForCreation()
	{
	}

	public void UpgradeRank()
	{
	}

	public void DowngradeRank()
	{
	}
}
