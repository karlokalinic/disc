using System.Collections.Generic;
using DG.Tweening;
using Pages.Gameplay.Journal;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;

namespace Pages.Gameplay.Map
{
	public class SkillcheckListPage : DiscoPage
	{
		public Transform checksListContent;

		public PageSystemJournalWhiteCheckUI whiteCheckItemPrefab;

		private JournalNavigationParameters journalParameters;

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

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private void DrawWhiteChecks(HashSet<WhiteCheck> whiteChecks)
		{
		}

		private void InstantiateWhiteCheckUI(WhiteCheck whiteCheck)
		{
		}
	}
}
