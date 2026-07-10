using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class InventoryTutorial : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private Image background;

		[SerializeField]
		private Button openButton;

		[SerializeField]
		private Button closeButton;

		private InventoryItem currentItem;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Refresh(InventoryItem item)
		{
		}

		private bool ShouldShowTutorial(InventoryItem item)
		{
			return false;
		}

		private void Show(InventoryItem item)
		{
		}

		private void Hide()
		{
		}

		private void Open()
		{
		}

		private void Close()
		{
		}
	}
}
