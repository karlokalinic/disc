using DG.Tweening;
using DiscoPages.Elements;
using PagesSystem;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Common.Charsheet
{
	public class SkillInfoPage : DiscoPage
	{
		[SerializeField]
		private Button[] skillOverviewNavigateButtons;

		[SerializeField]
		private TextMeshProUGUI titleText;

		[SerializeField]
		private TextMeshProUGUI shortDescription;

		[SerializeField]
		private TextMeshProUGUI longDescription;

		[SerializeField]
		private TabSwitchAnimationController tabSwitchAnimationController;

		private CharsheetPage charsheetPage;

		private SkillPortraitPanelPageSystem portrait;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private void OnButtonClicked()
		{
		}

		public override Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public override Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}
	}
}
