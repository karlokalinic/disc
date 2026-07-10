using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class RemoveButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		private Button button;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSelectionChanged(CollageElement collageElement, SelectionMode selectionMode)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
