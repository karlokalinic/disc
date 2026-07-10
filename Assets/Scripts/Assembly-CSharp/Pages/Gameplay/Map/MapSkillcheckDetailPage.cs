using PagesSystem;
using Sunshine.Views;
using UnityEngine;

namespace Pages.Gameplay.Map
{
	public class MapSkillcheckDetailPage : DiscoPage
	{
		[SerializeField]
		private PageSystemJournalWhiteCheckUI whiteCheckUI;

		private SelectedSkillcheckParameter checkParameter;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}
