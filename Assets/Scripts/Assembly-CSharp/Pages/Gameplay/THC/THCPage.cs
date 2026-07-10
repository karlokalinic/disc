using DG.Tweening;
using DiscoPages.Elements.Common;
using PagesSystem;
using Sunshine;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.THC
{
	public class THCPage : SubPage
	{
		private const int NUM_OF_SLOTS = 12;

		[SerializeField]
		private ThoughtSlot slotPrefab;

		[SerializeField]
		private RectTransform[] columns;

		[SerializeField]
		private Button statsNavigateButton;

		[SerializeField]
		private Button thcNavigateButton;

		[SerializeField]
		private Color pressedButtonColor;

		private Color baseButtonColor;

		private ThoughtSlot[] slots;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public override Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}

		public override void Initialize()
		{
		}

		public override void OnStackInitialized()
		{
		}

		public override void RefreshOnStackChanged()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		private void RefreshSlots()
		{
		}

		private void OnBuySlotClicked(ThoughtSlot slot)
		{
		}

		public void OnStatsButtonClicked()
		{
		}

		public void OnThcNavigateButtonClicked()
		{
		}

		private void OnClicked(ThoughtSlot slot)
		{
		}
	}
}
