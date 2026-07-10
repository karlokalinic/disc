using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DiscoPages.Elements.Dialogue
{
	public class DraggableResponse : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[SerializeField]
		private RectTransform draggableResponsePrefab;

		[SerializeField]
		private TextMeshProUGUI[] textFields;

		[SerializeField]
		private Button responseButton;

		private RectTransform draggableParent;

		private RectTransform draggableInstance;

		private RectTransform myRect;

		private float xOffset;

		private void Start()
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void SetDraggedPosition(PointerEventData data)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
