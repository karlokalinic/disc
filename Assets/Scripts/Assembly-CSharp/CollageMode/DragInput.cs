using UnityEngine;
using UnityEngine.EventSystems;

namespace CollageMode
{
	public class DragInput : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler
	{
		private LMBDragAction lmbDragAction;

		private RMBDragAction rmbDragAction;

		private TwoAxisDragAction scrollDragAction;

		private TwoAxisDragAction gamepadLeftStickDragAction;

		private TwoAxisDragAction gamepadRightStickDragAction;

		private TwoAxisDragAction gamepadScaleDragAction;

		public DragAction LMBDragAction => null;

		public DragAction RMBDragAction => null;

		public TwoAxisDragAction ScrollDragAction => null;

		public TwoAxisDragAction GamepadLeftStickDragAction => null;

		public TwoAxisDragAction GamepadRightStickDragAction => null;

		public TwoAxisDragAction GamepadScaleDragAction => null;

		private void Update()
		{
		}

		public void Abort()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}
	}
}
