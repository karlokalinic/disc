using DG.Tweening;
using DiscoPages.Elements.Common;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay
{
	public class StatsOverlayPage : DiscoPage
	{
		[SerializeField]
		private Image background;

		[SerializeField]
		private Button backButton;

		[SerializeField]
		private StatsView statsView;

		[SerializeField]
		private SwipeDetector swipeDetector;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
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

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		public override void RefreshOnStackChanged()
		{
		}

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}
	}
}
