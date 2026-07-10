using System.Collections.Generic;
using DiscoPages.Elements.Common;
using DiscoPages.Elements.Inventory;
using PagesSystem;
using Sunshine;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.Inventory
{
	public class InventoryItemsPage : SubPage
	{
		[SerializeField]
		private Button statsOverlayButton;

		[SerializeField]
		private PageSystemInventoryTabPanel tabPanel;

		[SerializeField]
		private InventoryTooltip tooltip;

		private Dictionary<ItemTabGroup, Dictionary<int, string>> tabContents;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}

		private void RefreshItems()
		{
		}

		private void SelectPreviouslySelected()
		{
		}

		public override void RefreshOnStackChanged()
		{
		}

		public void RefreshSlotAt(ItemTabGroup group, int index)
		{
		}
	}
}
