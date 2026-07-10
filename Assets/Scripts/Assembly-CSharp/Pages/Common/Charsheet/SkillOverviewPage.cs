using System.Collections.Generic;
using DG.Tweening;
using DiscoPages.Elements;
using PagesSystem;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Common.Charsheet
{
	public class SkillOverviewPage : DiscoPage
	{
		[SerializeField]
		private Button[] skillInfoNavigateButtons;

		[SerializeField]
		private SegmentIndicator portraitSkillPipIndicator;

		[SerializeField]
		private SkillPortraitAnimatorHelperPageSystem skillPortraitAnimatorHelper;

		[SerializeField]
		protected Button leftArrowButton;

		[SerializeField]
		protected Button rightArrowButton;

		[SerializeField]
		protected Button confirmButton;

		[SerializeField]
		protected SkillPortraitOverviewPanel portraitOverviewPanel;

		[SerializeField]
		protected SkillPortraitOverviewPanel leftPortraitOverviewPanel;

		[SerializeField]
		protected SkillPortraitOverviewPanel rightPortraitOverviewPanel;

		[SerializeField]
		protected TabSwitchAnimationController tabSwitchAnimationController;

		[SerializeField]
		protected SwipeUIElementSelectionController swipeAnimatorController;

		protected string titleTextStr;

		protected string shortDescriptionTextStr;

		protected string longDescriptionTextStr;

		private CharsheetPage charsheetPage;

		private SkillPortraitPanelPageSystem portraitPanel;

		private SkillPortraitPanelPageSystem leftPortraitPanel;

		private SkillPortraitPanelPageSystem rightPortraitPanel;

		protected Skill skill;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
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

		public virtual void UpdateData()
		{
		}

		public virtual void ShowModifiable(Modifiable modifiable, SkillPortraitPanelPageSystem portraitPanel, bool showBonusText = true)
		{
		}

		protected virtual void ShowSkill(Skill skill, SkillPortraitPanelPageSystem portraitPanel)
		{
		}

		protected string GatherModifiableData(Modifiable modifiable)
		{
			return null;
		}

		private static void PerceptionSpecialBehaviour(Modifiable modifiable, List<Modifier> modifiersToDisplay)
		{
		}

		private void NavigatePortraitLeft(bool invokedOnClick = false)
		{
		}

		private void NavigatePortraitRight(bool invokedOnClick = false)
		{
		}

		private void NavigatePortrait(int dir, bool invokedOnClick = false)
		{
		}

		private void NavigateToSkillInfo()
		{
		}
	}
}
