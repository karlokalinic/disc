using DG.Tweening;
using DiscoPages.Elements.Common;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;

namespace Pages.Gameplay.Journal
{
	public class BadgePage : SubPage
	{
		[SerializeField]
		private GameObject profileMissing;

		[SerializeField]
		private GameObject profileDiscovered;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

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

		public override Sequence GetTransitionOutSequence(PageContent previousPage)
		{
			return null;
		}

		public override void Initialize()
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}
	}
}
