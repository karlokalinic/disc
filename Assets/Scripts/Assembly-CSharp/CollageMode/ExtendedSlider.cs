using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CollageMode
{
	public class ExtendedSlider : Slider, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
	{
		public UnityEvent<float> onEditStarted;

		public UnityEvent<float> onEditFinished;

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
