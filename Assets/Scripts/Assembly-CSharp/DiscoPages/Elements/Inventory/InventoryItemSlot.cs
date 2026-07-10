using Sunshine.Metric;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DiscoPages.Elements.Inventory
{
	public class InventoryItemSlot : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[SerializeField]
		private Image itemImage;

		[SerializeField]
		private Image backgroundImage;

		private InventoryItem item;

		private string itemName;

		private AsyncImageLoader asyncImageLoader;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void DockItem(string itemName)
		{
		}

		public void RemoveItem()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void OnImageLoaded()
		{
		}
	}
}
