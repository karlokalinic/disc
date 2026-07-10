using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CollageMode
{
	public class ExtendedButton : Button, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
	{
		private const float REPEAT_INITIAL_WAIT = 0f;

		private const float REPEAT_SPEEDUP_WAIT = 2f;

		private const float REPEAT_INTERVAL = 0.12f;

		private const float REPEAT_SPEEDUP_INTERVAL = 0.06f;

		private float repeatTime;

		private float holdStartedTime;

		[SerializeField]
		private bool repeat;

		public UnityEvent onRepeat { get; set; }

		public bool Pressed { get; private set; }

		private void Update()
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		private float CalculateRepeatInterval()
		{
			return 0f;
		}
	}
}
