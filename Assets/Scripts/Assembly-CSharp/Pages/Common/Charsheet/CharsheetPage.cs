using System.Collections.Generic;
using DG.Tweening;
using DiscoPages.Elements;
using DiscoPages.Elements.Charsheet;
using DiscoPages.Elements.Common;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Common.Charsheet
{
	public class CharsheetPage : SubPage
	{
		private static CharsheetPage singleton;

		[SerializeField]
		protected List<PageSystemStatPanel> stats;

		[SerializeField]
		protected List<SkillPortraitPanelPageSystem> portraits;

		[SerializeField]
		private Button maximizeButton;

		[SerializeField]
		private Button minimizeButton;

		[SerializeField]
		private SwipeDetector[] swipeDetectors;

		private bool abilitiesOpened;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		protected virtual CharSheetMode charSheetMode => default(CharSheetMode);

		public bool AbilitiesOpened => false;

		public List<SkillPortraitPanelPageSystem> Portraits => null;

		public static CharsheetPage Singleton => null;

		public override void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateData()
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

		public void MaximizeAbility()
		{
		}

		public void MinimizeAbility()
		{
		}

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}
	}
}
