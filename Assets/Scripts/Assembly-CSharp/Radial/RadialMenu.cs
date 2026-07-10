using UnityEngine;
using UnityEngine.UI;

namespace Radial
{
	public class RadialMenu : MonoBehaviour
	{
		public Image CharSheet;

		public Image CharSheetTape;

		public Image CharSheetButton;

		public Sprite CharSheetOpen;

		public Sprite CharSheetClosed;

		public Image Inventory;

		public Image InventoryTape;

		public Image InventoryButton;

		public Sprite InventoryOpen;

		public Sprite InventoryClosed;

		public Image Thc;

		public Image ThcTape;

		public Image ThcButton;

		public Sprite ThcOpen;

		public Sprite ThcClosed;

		public Image Journal;

		public Image JournalTape;

		public Image JournalButton;

		public Sprite JournalOpen;

		public Sprite JournalClosed;

		public Image Arrow;

		public Sprite TapeHighlighted;

		public Sprite TapeNormal;

		private float angle;

		public Selection currentSelection;

		private void Awake()
		{
		}

		public void SetPreviousSelection()
		{
		}

		private void Update()
		{
		}

		public void SetSelection(Selection selection)
		{
		}

		private void resetAllIcons()
		{
		}

		private static float WrapAngle(float angle)
		{
			return 0f;
		}
	}
}
