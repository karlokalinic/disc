using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.Inventory
{
	public class InventoryEquipmentSlot : MonoBehaviour
	{
		[SerializeField]
		private EquipmentSlotType slotType;

		[SerializeField]
		private Image fillImage;

		[SerializeField]
		private Image itemImage;

		[SerializeField]
		private TextMeshProUGUI slotTypeText;

		private string prevItemName;

		private AsyncImageLoader asyncImageLoader;

		public EquipmentSlotType SlotType => default(EquipmentSlotType);

		private void Awake()
		{
		}

		public void DockItem(string itemName)
		{
		}

		public void RemoveItem()
		{
		}

		private void OnImageLoaded()
		{
		}
	}
}
