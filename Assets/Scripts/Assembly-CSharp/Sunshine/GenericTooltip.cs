using TMPro;

namespace Sunshine
{
	public class GenericTooltip : Tooltip<GenericTooltip>
	{
		public TextMeshProUGUI Title;

		public TextMeshProUGUI Description;

		public TextMeshProUGUI NumericInfo;

		protected override void Awake()
		{
		}

		public override void SetTooltipContent(TooltipSource tooltipSource)
		{
		}

		private string ProcessText(string text)
		{
			return null;
		}
	}
}
