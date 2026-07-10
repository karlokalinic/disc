using DiscoPages.Elements;
using PagesSystem;

namespace Pages.Common.Charsheet
{
	public class SkillInfoNavigationParameters : NavigationParameters
	{
		public string titleText;

		public string shortDescriptionText;

		public string longDescriptionText;

		public CharsheetPage charsheetPage;

		public SkillPortraitPanelPageSystem portrait;

		public SkillInfoNavigationParameters(string titleText, string shortDescriptionText, string longDescriptionText, CharsheetPage charsheetPage, SkillPortraitPanelPageSystem portrait)
		{
		}
	}
}
