using DiscoPages.Elements;
using PagesSystem;
using Sunshine.Metric;

namespace Pages.Common.Charsheet
{
	public class SkillOverviewNavigationParameters : NavigationParameters
	{
		public Modifiable modifiable;

		public SkillPortraitPanelPageSystem portraitPanel;

		public CharsheetPage charsheetPage;

		public SkillOverviewNavigationParameters(Modifiable modifiable, SkillPortraitPanelPageSystem portraitPanel, CharsheetPage charsheetPage)
		{
		}
	}
}
