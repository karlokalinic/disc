using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sunshine.Journal
{
	public class QuicktravelButton : Selectable
	{
		public string locationMarker;

		[SerializeField]
		private float activationDistance;

		[SerializeField]
		private CanvasGroup travelHereLabel;

		[SerializeField]
		private CanvasGroup youAreHereLabel;

		[SerializeField]
		private new Image image;

		[SerializeField]
		private Image actionButton;

		public bool wasVisited;

		private bool isActive;

		public void SetActive(bool state)
		{
		}

		private void Update()
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public bool CheckTequilaInActivationRadius()
		{
			return false;
		}

		private void QuicktravelToTarget()
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public override void OnDeselect(BaseEventData eventData)
		{
		}

		public new void Select()
		{
		}

		public void Deselect()
		{
		}
	}
}
