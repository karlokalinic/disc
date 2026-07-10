using System.Collections;
using DG.Tweening;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.MainMenu
{
	public class CityViewLandingPage : DiscoPage
	{
		[SerializeField]
		private Button hiddenForwardButton;

		[SerializeField]
		private GameObject buttonGroups;

		public override bool CanStayOnStack => false;

		public override bool IsBackPossible => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private IEnumerator DEBUG_ShowMainMenuPageButtons()
		{
			return null;
		}

		public override void OnNavigatedFrom()
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
