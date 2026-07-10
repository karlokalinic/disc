using System.Collections.Generic;
using DG.Tweening;
using DiscoPages.Elements.Common;
using DiscoPages.Elements.THC;
using PagesSystem;
using Sunshine;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.THC
{
	public class THCListPage : SubPage
	{
		private static int sortingOptionsEnumCount;

		public static SortingOptions ListSortingOption;

		[SerializeField]
		private PageSystemThoughtOceanSlot thoughtButtonPrefab;

		[SerializeField]
		private RectTransform[] columns;

		[SerializeField]
		private InPageMessage thoughtNotUnlockedMessage;

		[SerializeField]
		private Button sortButton;

		private TextMeshProUGUI sortLabel;

		private PageSystemThoughtOceanSlot[] listOfSlots;

		private ThoughtSlot selectedSlot;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		protected override void Awake()
		{
		}

		public override void OnStackInitialized()
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

		public override void OnNavigatedFrom()
		{
		}

		private void OnSortButtonPressed()
		{
		}

		private void SortAZ()
		{
		}

		private void SortZA()
		{
		}

		private void SortState()
		{
		}

		private void SortThoughtsSlots(List<PageSystemThoughtOceanSlot> thoughts)
		{
		}

		private void RefreshSortButtonLabel()
		{
		}

		private void RefreshSlots()
		{
		}

		private void CreateThoughtsList()
		{
		}
	}
}
