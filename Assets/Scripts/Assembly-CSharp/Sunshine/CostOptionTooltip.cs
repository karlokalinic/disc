using TMPro;
using UnityEngine.UI;

namespace Sunshine
{
	public class CostOptionTooltip : Tooltip<CostOptionTooltip>
	{
		public HorizontalLayoutGroup titleGroup;

		public TextMeshProUGUI costLabel;

		public TextMeshProUGUI cost;

		public HorizontalLayoutGroup contentPanelGroup;

		public TextMeshProUGUI leftSide;

		public TextMeshProUGUI rightSide;

		public TextMeshProUGUI explanation;

		private string canAffordColor;

		private string cannotAffordColor;

		public static string YOUHAVE => null;

		public static string COST => null;

		public override void SetTooltipContent(TooltipSource tooltipSource)
		{
		}

		private void SetColors()
		{
		}
	}
}
