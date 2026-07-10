using UnityEngine;
using UnityEngine.EventSystems;

namespace CollageMode
{
	public class ActivateOnHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[SerializeField]
		private GameObject activatedObject;

		private void OnEnable()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
