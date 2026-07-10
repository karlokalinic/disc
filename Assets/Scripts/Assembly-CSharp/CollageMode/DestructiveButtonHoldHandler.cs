using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CollageMode
{
	public class DestructiveButtonHoldHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[SerializeField]
		private Image timeIndicator;

		[SerializeField]
		private Button button;

		[SerializeField]
		private float holdTime;

		[SerializeField]
		private bool holdOnMouse;

		[SerializeField]
		private bool holdOnGamepad;

		[SerializeField]
		private CollageInputType gamepadInputType;

		public UnityEvent onStarted;

		public UnityEvent onPerformed;

		private bool isHeld;

		private float holdStartTime;

		public Button Button => null;

		private void Update()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		private void BeginHold()
		{
		}

		private void FinishHold()
		{
		}
	}
}
