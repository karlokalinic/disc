using TMPro;

namespace Sunshine
{
	public class HoverTooltip : Tooltip<HoverTooltip>
	{
		public TextMeshProUGUI titleText;

		public TextMeshProUGUI properties;

		public TextMeshProUGUI description;

		private bool firstLineFlag;

		private string NewLine => null;

		public override void SetTooltipContent(TooltipSource tooltipSource)
		{
		}
	}
}
