using System.Collections.Generic;
using DG.Tweening;
using PagesSystem;
using Sunshine;
using Sunshine.Metric;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.THC
{
	public class THCDetailsPage : DiscoPage
	{
		private const string THOUGHT_IMAGE_PATH = "thought_icons/";

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private Image graphic;

		[SerializeField]
		private Image nextGraphic;

		[SerializeField]
		private Image previousGraphic;

		[SerializeField]
		private Image thoughtResearchFillAmount;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI subtitle;

		[SerializeField]
		private TextMeshProUGUI researchBonus;

		[SerializeField]
		private TextMeshProUGUI description;

		[SerializeField]
		private TextMeshProUGUI actionButtonLabel;

		[SerializeField]
		private Button actionButton;

		[SerializeField]
		private XPPanel xpPanel;

		[SerializeField]
		private Button selectNextThoughtButton;

		[SerializeField]
		private Button selectPreviousThoughtButton;

		[SerializeField]
		private TabSwitchAnimationController tabSwitchAnimationController;

		[SerializeField]
		private SwipeUIElementSelectionController swipeUiController;

		[SerializeField]
		private Button[] toggleProblemSolutionButtons;

		private Color baseProblemSolutionColor;

		private List<ThoughtListItem> discoveredThoughts;

		private bool isSolutionOn;

		private ThoughtSlot selectedSlot;

		private ThoughtCabinetProject thoughtProject;

		private ThoughtCabinetProject nextThoughtProject;

		private ThoughtCabinetProject previousThoughtProject;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSelectNextButtonPressed()
		{
		}

		private void OnSelectPreviousButtonPressed()
		{
		}

		private void ChangeShownThought(ThoughtCabinetProject project)
		{
		}

		private ThoughtCabinetProject GetNext(int whichNext)
		{
			return null;
		}

		private void OnProblemButtonPressed()
		{
		}

		private void OnProblemButtonPressed(bool noAnimation)
		{
		}

		private void OnSolutionButtonPressed()
		{
		}

		private void OnSolutionButtonPressed(bool noAnimation)
		{
		}

		private void OnToggleProblemSolutionButtonPressed()
		{
		}

		private void OnActionButtonPressed()
		{
		}

		private void SetThoughtStateAndGoBack()
		{
		}

		private void RefreshUI()
		{
		}

		private void SetPropertiesDescription(bool isFixed, bool first)
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void RefreshOnStackChanged()
		{
		}

		private static string GetPropertiesDescription(bool isFixed, bool first, ThoughtCabinetProject thought)
		{
			return null;
		}

		private static void SetAndShowGraphicIfProjectNotNull(ThoughtCabinetProject thoughtProject, Image graphic)
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
