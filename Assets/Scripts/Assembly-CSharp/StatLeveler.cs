using Sunshine;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.UI;

public class StatLeveler : MonoBehaviour
{
	public Button levelUp;

	public Button levelDown;

	private StatPanel statPanel;

	protected AbilityType ability;

	protected TooltipSource tooltipSource;

	public Button ButtonPlus => null;

	public Button ButtonMinus => null;

	public void Awake()
	{
	}

	public virtual void UpdateData(bool showUp, bool showDown)
	{
	}

	public virtual void UpgradeRank()
	{
	}

	public virtual void DowngradeRank()
	{
	}
}
