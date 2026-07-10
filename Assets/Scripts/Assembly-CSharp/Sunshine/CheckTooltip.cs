using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class CheckTooltip : Tooltip<CheckTooltip>
	{
		public HorizontalLayoutGroup titleLayoutGroup;

		public TextMeshProUGUI titleText;

		public TextMeshProUGUI titleProbability;

		public TextMeshProUGUI resultsBox;

		public GameObject divider;

		public TextMeshProUGUI explainBox;

		public TextMeshProUGUI explanation;

		protected override void OnEnable()
		{
		}

		public override void SetTooltipContent(TooltipSource tooltipSource)
		{
		}

		private string HumanizeProbability(float probability)
		{
			return null;
		}

		private string GetRollResult(CheckResult data)
		{
			return null;
		}

		private string GetRollStats(CheckResult data)
		{
			return null;
		}
	}
}
