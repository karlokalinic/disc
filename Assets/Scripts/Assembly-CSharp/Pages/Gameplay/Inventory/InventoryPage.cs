using System.Collections.Generic;
using DG.Tweening;
using DiscoPages.Elements.Common;
using DiscoPages.Elements.Inventory;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.Inventory
{
	public class InventoryPage : SubPage
	{
		private static readonly int INTERRUPT;

		[SerializeField]
		private Button statsOverlayButton;

		[SerializeField]
		private Button inventoryItemsNavigateButton;

		[SerializeField]
		private InventoryEquipmentSlot[] equipmentSlots;

		[SerializeField]
		private SwipeDetector swipeDetector;

		private Dictionary<EquipmentSlotType, InventoryEquipmentSlot> equipment;

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

		public override void Initialize()
		{
		}

		public override void RefreshOnStackChanged()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private void RefreshEquipment(Dictionary<EquipmentSlotType, string> equipmentData)
		{
		}

		public override void OnNavigatedFrom()
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

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}

		public void NotifyActivation(ViewType inventoryViewType)
		{
		}

		public void NotifyDeactivation(ViewType nextView)
		{
		}

		private void SetAnimatorInterruptTrigger(bool set)
		{
		}
	}
}
