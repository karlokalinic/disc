using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.Inventory
{
	public class PageSystemInventoryTabButton : MonoBehaviour
	{
		public delegate void ChangeGroupMethod(ItemTabGroup group, bool immediate);

		[SerializeField]
		private Button button;

		[SerializeField]
		private TMP_Text text;

		[SerializeField]
		private Color enabledTabTextColor;

		[SerializeField]
		private Color disabledTabTextColor;

		[SerializeField]
		[Space]
		private ItemTabGroup buttonType;

		private ChangeGroupMethod changeGroup;

		private TweenRectTransform selectedTabBackground;

		private RectTransform rectTransform;

		public ItemTabGroup ButtonType => default(ItemTabGroup);

		public void InitializeTabButton(TweenRectTransform selectedTabBackground, ChangeGroupMethod changeGroupMethod)
		{
		}

		public void OnGroupChanged(ItemTabGroup group)
		{
		}

		private void EnableTab()
		{
		}

		private void DisableTab()
		{
		}
	}
}
