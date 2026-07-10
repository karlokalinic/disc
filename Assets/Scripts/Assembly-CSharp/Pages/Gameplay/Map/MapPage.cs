using System.Collections.Generic;
using DG.Tweening;
using Pages.Gameplay.Journal;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.Map
{
	public class MapPage : SubPage
	{
		[SerializeField]
		private Button skillcheckNavigateButton;

		[SerializeField]
		private Button mapSkillcheckPrefab;

		[SerializeField]
		private RectTransform mapRect;

		private JournalNavigationParameters journalParameters;

		private Dictionary<Vector2, HashSet<WhiteCheck>> coordinatesChecks;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
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

		private void OnSkillCheckPageClicked()
		{
		}

		private void OnMapSkillcheckDetailPageClicked(WhiteCheck whiteCheck, Vector2 coordinates)
		{
		}

		private void DrawCoordinates(HashSet<WhiteCheck> checks)
		{
		}
	}
}
