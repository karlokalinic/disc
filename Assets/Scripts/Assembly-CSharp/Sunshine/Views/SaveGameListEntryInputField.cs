using UnityEngine;
using UnityEngine.EventSystems;

namespace Sunshine.Views
{
	public class SaveGameListEntryInputField : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ISelectHandler
	{
		[SerializeField]
		private SaveGameListEntry saveGameListEntry;

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}
	}
}
