using System.Collections;
using DG.Tweening;
using PagesSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.MainMenu
{
	public class InitialIntroPage : DiscoPage
	{
		[SerializeField]
		private float transmissionToNextPage;

		[SerializeField]
		private Button hiddenForwardButton;

		[SerializeField]
		private Image zaumLogo;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		private void Reset()
		{
		}

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private IEnumerator NavigateToNextPage(float duration)
		{
			return null;
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
