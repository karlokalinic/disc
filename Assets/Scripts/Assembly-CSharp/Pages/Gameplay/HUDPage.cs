using System.Collections;
using DG.Tweening;
using DiscoPages.Elements.HUD;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay
{
	public class HUDPage : DiscoPage
	{
		private const float ANIMATION_DURATION = 0.37f;

		[SerializeField]
		private Image raycastBlocker;

		[SerializeField]
		private RectTransform substackRectTransform;

		[SerializeField]
		private Button dialogueButton;

		[SerializeField]
		private PageStack subStack;

		[SerializeField]
		private Button charsheetNavigateButton;

		[SerializeField]
		private Button inventoryNavigateButton;

		[SerializeField]
		private Button journalNavigateButton;

		[SerializeField]
		private Button thcNavigateButton;

		[SerializeField]
		private Button mainMenuNavigateButton;

		[SerializeField]
		private RectTransform moneyTimePortraitsBar;

		[SerializeField]
		private RectTransform backTapeBar;

		[SerializeField]
		private RectTransform quickAccessBar;

		[SerializeField]
		private PageSystemHUDPortraitsAnimator portraitsAnimator;

		[SerializeField]
		private Button writersToolToggle;

		private float initMoneyTimeAnchorMinY;

		private float initMoneyTimeAnchorMaxY;

		private float initQuickAccessBarAnchorMinY;

		private float initQuickAccessBarAnchorMaxY;

		private float quickAccessBarNormalizedHeight;

		private float moneyTimeNormalizedHeight;

		private bool quickAccessBarMinimized;

		private Sequence quickAccessBarSequence;

		private Coroutine orbitStateSetDirtyCor;

		public override bool IsBackPossible => false;

		public override bool CanStayOnStack => false;

		public override bool IsTitleLabelVisible => false;

		public override ViewType ViewType => default(ViewType);

		protected override void Awake()
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

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private void OnSubpagePush(PageContent page)
		{
		}

		public override void RefreshOnStackChanged()
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		public override void Initialize()
		{
		}

		private void OnNavigateButtonClicked<T>(NavigationParameters navigationParameters = null) where T : PageContent
		{
		}

		private void OnTHCPageClicked()
		{
		}

		private void ShakeupOrbs()
		{
		}

		private IEnumerator SetOrbitStateDirtyAfterDelay()
		{
			return null;
		}

		private Sequence AnimateAnchorsY(RectTransform rt, float minY, float maxY)
		{
			return null;
		}

		private void MinimizeQuickAccessBar()
		{
		}

		private void MaximizeQuickAccessBar()
		{
		}
	}
}
